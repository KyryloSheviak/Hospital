using Hospital.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospital.DAL.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(c => c.Doctor)
                .WithOne(c => c.ApplicationUser)
                .HasForeignKey<Doctor>(c => c.ApplicationUserId);

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(c => c.Patient)
                .WithOne(c => c.ApplicationUser)
                .HasForeignKey<Patient>(c => c.ApplicationUserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}