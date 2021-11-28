using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "9cb4f0f1-91cf-400c-8fc5-9e7df68d2ac3",
                    UserId = "8e3a2d7b-656e-4526-8343-7ecc99c38d89"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a4e4275c-0212-4c1b-b82c-f1a71676af7a",
                    UserId = "b7d621da-0fc2-43d9-8219-32e8e3778d6f"
                }
             );
        }
    }
}
