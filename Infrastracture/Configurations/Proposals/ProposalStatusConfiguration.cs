using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Core.Constants.Proposal;

namespace Prohix.Infrastracture.Configurations.Proposals
{
    public class ProposalStatusConfiguration : IEntityTypeConfiguration<ProposalStatus>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<ProposalStatus> builder)
        {
            builder.HasOne(q => q.Proposal)
                .WithMany(q => q.ProposalStatuses)
                .HasForeignKey(q => q.ProposalId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(q => q.Teacher)
                .WithMany(q => q.ProposalStatuses)
                .HasForeignKey(q => q.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.ToTable("ProposalStatuses");
        }
    }
}
