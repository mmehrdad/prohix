using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Configurations.Students
{
    public class EducationConfiguration : IEntityTypeConfiguration<Education>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("Educations");
        }
    }
}
