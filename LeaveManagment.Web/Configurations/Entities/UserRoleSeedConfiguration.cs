using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagment.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "32cb1c44-74ac-5544-9c54-c5e6cbc74821", // Replace with an existing UserId
                    RoleId = "32cb1c44-74ac-8888-9c54-c5e6cbc74821" // Replace with an existing RoleId
                }
               
            );
        }
    }
}
