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
    public class TeacherInUniversityConfiguration : IEntityTypeConfiguration<TeacherInUniversity>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<TeacherInUniversity> builder)
        {



            builder.HasOne(q => q.Teacher)
                .WithMany(q => q.TeacherInUniversities)
                .HasForeignKey(q => q.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(q => q.University)
                .WithMany(q => q.TeacherInUniversities)
                .HasForeignKey(q => q.UniversityId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("TeacherInUniversities");
        }
    }
}
