using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Configurations.Identity
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasOne(q => q.Role)
                .WithMany(q => q.Users)
                .HasForeignKey(q => q.RoleId);

            builder.HasOne(q => q.User)
                .WithMany(q => q.Roles)
                .HasForeignKey(q => q.UserId);

            builder.ToTable("UserRoles");
        }
    }
}
