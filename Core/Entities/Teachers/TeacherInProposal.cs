﻿using Prohix.Core.Entities.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Teachers
{
    public class TeacherInProposal
    {
        public long ID { get; set; }
        public Proposal Proposal { get; set; }
        public long ProposalId { get; set; }
        public Teacher Teacher { get; set; }
        public long TeacherID { get; set; }
        public ProposalStatus ProposalStatus { get; set; }
    }
}