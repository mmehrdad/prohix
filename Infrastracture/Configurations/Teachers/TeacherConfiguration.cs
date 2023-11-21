using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Configurations.Teachers
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {

            builder.ToTable("Teachers");
        }
    }
}
