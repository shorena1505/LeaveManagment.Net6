using LeaveManagment.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagment.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "32cb1c44-74ac-8888-9c54-c5e6cbc74821",
                    Email ="Admin@localhost.com",
                    NormalizedEmail="ADMIN@LOCALHOST.COM",
                    UserName= "Admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    FirstName ="Shorena",
                    LastName="Nemsadze",
                    PasswordHash=hasher.HashPassword(null, "P@ssword!"),
                    EmailConfirmed=true


                },
                 new Employee
                 {
                     Id = "32cb1c44-74ac-7204-9c54-c5e6cbc74821",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     UserName = "user@localhost.com",
                     NormalizedUserName = "USER@LOCALHOST.COM",
                     FirstName = "Petre",
                     LastName = "Oglu",
                     PasswordHash = hasher.HashPassword(null, "P@ssword!"),
                     EmailConfirmed = true


                 }

           );
        }
    }
}