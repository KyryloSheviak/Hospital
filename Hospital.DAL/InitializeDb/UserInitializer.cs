using Hospital.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Hospital.DAL.InitializeDb
{
    public class UserInitializer : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            // ivd-nE7-8uc-Mzk
            builder.HasData(new ApplicationUser
                {
                    Id = 2, 
                    UserName = "adminTest@gmail.com", 
                    Email = "adminTest@gmail.com",
                    NormalizedEmail = "ADMINTEST@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = "AQAAAAEAACcQAAAAEAju1DJkAZGmRKbPPr7g9P98dCkqAS/Rv3TsLa1sOu/rZ7O71Y7gDcpsjS2sKEKPRQ=="
                }
            );
        }
    }
}