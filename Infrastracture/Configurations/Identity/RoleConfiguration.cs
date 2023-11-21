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
    public class RoleConfiguration : IEntityTypeConfiguration<Role>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            

            builder.ToTable("Roles");
        }
    }
}
