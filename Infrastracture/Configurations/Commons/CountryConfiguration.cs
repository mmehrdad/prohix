using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Core.Entities.Commons;

namespace Prohix.Infrastracture.Configurations.Commons
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {

            
            builder.ToTable("Countries");
        }
    }
}
