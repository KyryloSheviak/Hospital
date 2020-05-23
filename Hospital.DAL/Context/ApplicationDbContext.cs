using Hospital.DAL.Entities;
using Hospital.DAL.InitializeDb;
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
        public DbSet<ReceptionStatus> ReceptionStatuses { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<WorkDay> WorkDays { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<ApplicationUser>() // Врач -> Пользователь
                .HasOne(c => c.Doctor)
                .WithOne(c => c.ApplicationUser)
                .HasForeignKey<Doctor>(c => c.ApplicationUserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationUser>() // Пациент -> Пользователь
                .HasOne(c => c.Patient)
                .WithOne(c => c.ApplicationUser)
                .HasForeignKey<Patient>(c => c.ApplicationUserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Doctor>() // Врач -> Отзывы
                .HasMany(x => x.Feedbacks)
                .WithOne(e => e.Doctor)
                .HasForeignKey(c => c.DoctorId);

            modelBuilder.Entity<Patient>() // Пациент -> Отзывы
                .HasMany(x => x.Feedbacks)
                .WithOne(e => e.Patient)
                .HasForeignKey(c => c.PatientId);

            modelBuilder.Entity<History>() //История -> Анализы
                .HasMany(x => x.Analyses)
                .WithOne(x => x.History)
                .HasForeignKey(x => x.HistoryId);

            modelBuilder.Entity<Doctor>() // Врач -> История
                .HasMany(c => c.Histories)
                .WithOne(c => c.Doctor)
                .HasForeignKey(c => c.DoctorId);

            modelBuilder.Entity<Doctor>() //Врач -> Приемы
                .HasMany(c => c.WorkDays)
                .WithOne(x => x.Doctor)
                .HasForeignKey(x => x.DoctorId);

            modelBuilder.Entity<Patient>() // Пациент -> Приемы
                .HasMany(c => c.Receptions)
                .WithOne(c => c.Patient)
                .HasForeignKey(c => c.PatientId);

            modelBuilder.Entity<WorkDay>() // Прием -> Статус
                .HasOne(x => x.ReceptionStatus)
                .WithOne(x => x.Reception)
                .HasForeignKey<ReceptionStatus>(e => e.ReceptionId);

            modelBuilder.Entity<Patient>() // Врач -> Истории
                .HasMany(c => c.Histories)
                .WithOne(c => c.Patient)
                .HasForeignKey(c => c.PatientId);

            modelBuilder.ApplyConfiguration(new RoleInitializer());

            base.OnModelCreating(modelBuilder);
        }
    }
}