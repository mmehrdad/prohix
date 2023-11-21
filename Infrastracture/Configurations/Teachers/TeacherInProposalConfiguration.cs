using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Core.Entities.Teachers;

namespace Prohix.Infrastracture.Configurations.Teachers
{
    public class TeacherInProposalConfiguration : IEntityTypeConfiguration<TeacherInProposal>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<TeacherInProposal> builder)
        {

            

            builder.HasOne(q => q.Proposal)
                .WithMany(q => q.TeacherInProposals)
                .HasForeignKey(q => q.ProposalId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(q => q.Teacher)
                .WithMany(q => q.TeacherInProposals)
                .HasForeignKey(q => q.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("TeacherInProposals");
        }
    }
}
