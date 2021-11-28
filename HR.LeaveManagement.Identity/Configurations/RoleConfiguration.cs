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
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id= "9cb4f0f1-91cf-400c-8fc5-9e7df68d2ac3",
                    Name="Employee",
                    NormalizedName="EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "a4e4275c-0212-4c1b-b82c-f1a71676af7a",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }

            );
        }
    }
}
