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
    public class TeacherInSubjectConfiguration : IEntityTypeConfiguration<TeacherInSubject>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<TeacherInSubject> builder)
        {



            builder.HasOne(q => q.Teacher)
                .WithMany(q => q.TeacherInSubjects)
                .HasForeignKey(q => q.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(q => q.Subject)
                .WithMany(q => q.TeacherInSubjects)
                .HasForeignKey(q => q.SubjectId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("TeacherInSubjects");
        }
    }
}
