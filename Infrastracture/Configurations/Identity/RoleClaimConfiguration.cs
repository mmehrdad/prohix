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
    public class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaim>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<RoleClaim> builder)
        {
            builder.HasOne(roleClaim => roleClaim.Role)
                   .WithMany(role => role.Claims)
                   .HasForeignKey(roleClaim => roleClaim.RoleId);

            builder.ToTable("RoleClaims");
        }
    }
}
