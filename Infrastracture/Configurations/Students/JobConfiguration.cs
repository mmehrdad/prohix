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
    public class JobConfiguration : IEntityTypeConfiguration<Job>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasOne(q => q.Student)
                .WithMany(q => q.Jobs)
                .HasForeignKey(q => q.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Jobs");
        }
    }
}
