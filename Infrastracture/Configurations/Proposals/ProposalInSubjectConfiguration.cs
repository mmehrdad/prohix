﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prohix.Core.Entities.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Configurations.Proposals
{
    public class ProposalInSubjectConfiguration : IEntityTypeConfiguration<ProposalInSubject>, IDbModelConfiguration
    {
        public void Configure(EntityTypeBuilder<ProposalInSubject> builder)
        {
            builder.ToTable("ProposalInSubjects");
        }
    }
}
