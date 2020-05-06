using Hospital.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.DAL.InitializeDb
{
    public class RoleInitializer : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(
                new ApplicationRole {Id = 1, Name = "admin", NormalizedName = "ADMIN" },
                new ApplicationRole {Id = 2, Name = "user", NormalizedName = "USER" },
                new ApplicationRole {Id = 3, Name = "doctor", NormalizedName = "DOCTOR" },
                new ApplicationRole {Id = 4, Name = "patient", NormalizedName = "PATIENT" },
                new ApplicationRole {Id = 5, Name = "manager", NormalizedName = "MANAGER" }
                );
        }
    }
}