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
            builder.HasOne(q => q.Student)
                .WithMany(q => q.Educations)
                .HasForeignKey(q => q.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(q => q.University)
                .WithMany(q => q.Educations)
                .HasForeignKey(q => q.UniversityId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(q => q.GradeOfStudy)
                .WithMany(q => q.Educations)
                .HasForeignKey(q => q.GradeOfStudyId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(q => q.FieldOfStudy)
                .WithMany(q => q.Educations)
                .HasForeignKey(q => q.FieldOfStudyId)
                .OnDelete(DeleteBehavior.NoAction);



            builder.ToTable("Educations");
        }
    }
}