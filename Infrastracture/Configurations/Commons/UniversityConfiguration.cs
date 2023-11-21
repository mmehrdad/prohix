using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Configurations.Commons
{
    public class UniversityConfiguration : IEntityTypeConfiguration<University>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {

            builder.ToTable("Universities");
        }
    }
}
