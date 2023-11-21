using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Configurations.Proposals
{
    public class ProposalConfiguration : IEntityTypeConfiguration<Proposal>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<Proposal> builder)
        {

            builder.HasOne(q => q.Student)
                .WithMany(q => q.Proposals)
                .HasForeignKey(q => q.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            

            builder.ToTable("Proposals");
        }
    }
}
