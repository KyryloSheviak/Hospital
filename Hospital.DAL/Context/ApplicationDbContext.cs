using Hospital.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hospital.DAL.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Analysis> Analyses { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<ReceptionStatus> ReceptionStatuses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<WorkDay> WorkDays { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(c => c.Doctor)
                .WithOne(c => c.ApplicationUser)
                .HasForeignKey<Doctor>(c => c.ApplicationUserId);

            modelBuilder.Entity<ApplicationUser>() // Пользователь -> Отзывы
                .HasMany(x => x.Reviews)
                .WithOne(e => e.ApplicationUser)
                .HasForeignKey(c => c.ApplicatioUserId);

            modelBuilder.Entity<History>()
                .HasMany(x => x.Analyses)
                .WithOne(x => x.History)
                .HasForeignKey(x => x.HistoryId);

            modelBuilder.Entity<Doctor>() // Врач -> История
                .HasMany(c => c.Histories)
                .WithOne(c => c.Doctor)
                .HasForeignKey(c => c.DoctorId);

            modelBuilder.Entity<Doctor>() //Врач -> Прием
                .HasMany(c => c.Receptions)
                .WithOne(x => x.Doctor)
                .HasForeignKey(x => x.DoctorId);

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(c => c.Patient)
                .WithOne(c => c.ApplicationUser)
                .HasForeignKey<Patient>(c => c.ApplicationUserId);

            // Врач -> Рабочий день
            modelBuilder.Entity<DoctorWorkDay>()
                .HasKey(x => new { x.DoctorId, x.WorkdDayId });

            modelBuilder.Entity<DoctorWorkDay>()
                .HasOne(x => x.Doctor)
                .WithMany(x => x.WorkDays)
                .HasForeignKey(x => x.DoctorId);

            modelBuilder.Entity<DoctorWorkDay>()
                .HasOne(x => x.WorkDay)
                .WithMany(x => x.Doctors)
                .HasForeignKey(x => x.WorkdDayId);

            modelBuilder.Entity<Patient>() // Пациент -> Прием
                .HasMany(c => c.Receptions)
                .WithOne(c => c.Patient)
                .HasForeignKey(c => c.PatientId);

            modelBuilder.Entity<Reception>()
                .HasOne(x => x.ReceptionStatus)
                .WithOne(x => x.Reception)
                .HasForeignKey<ReceptionStatus>(e => e.ReceptionId);

            modelBuilder.Entity<Patient>() // Врач -> История
                .HasMany(c => c.Histories)
                .WithOne(c => c.Patient)
                .HasForeignKey(c => c.PatientId);

            base.OnModelCreating(modelBuilder);
        }
    }
}