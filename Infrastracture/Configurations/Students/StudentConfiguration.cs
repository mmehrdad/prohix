using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Configurations.Students
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(q => q.MotherTongue)
                .WithOne(q => q.Student)
                .HasForeignKey<Student>(q => q.MotherTongueId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(q => q.SecondCitizenship)
                .WithOne(q => q.StudentCitizenship)
                .HasForeignKey<Student>(q => q.SecondCitizenshipId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(q => q.Citizenship)
                .WithOne(q => q.StudentSecondCitizenship)
                .HasForeignKey<Student>(q => q.CitizenshipId)
                .OnDelete(DeleteBehavior.NoAction);

            

            builder.ToTable("Students");
        }
    }
}
