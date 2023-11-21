using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Configurations.Identity
{
    public class UserConfiguration : IEntityTypeConfiguration<User>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(p => p.Student)
                   .WithOne(a => a.User)
                   .HasForeignKey<User>(p => p.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Teacher)
                  .WithOne(a => a.User)
                  .HasForeignKey<User>(p => p.TeacherId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Users");
        }
    }
}


