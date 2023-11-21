using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Configurations.Students
{
    public class StudentInLanguageConfiguration : IEntityTypeConfiguration<StudentInLanguage>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<StudentInLanguage> builder)
        {
            builder.HasOne(q => q.Student)
                .WithMany(q => q.StudentInLanguages)
                .HasForeignKey(q => q.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(q => q.Language)
                .WithMany(q => q.StudentInLanguages)
                .HasForeignKey(q => q.LanguageId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("StudentInLanguages");
        }
    }
}
