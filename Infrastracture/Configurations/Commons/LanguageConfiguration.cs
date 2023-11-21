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
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {

            builder.ToTable("Languages");
        }
    }
}
