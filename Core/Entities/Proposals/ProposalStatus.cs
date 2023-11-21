using Prohix.Core.Constants.Proposal;
using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Proposals
{
    public class ProposalStatus:BaseEntity<long>
    {
        public ProposalStatusEnum Status { get; set; }
        public Proposal Proposal { get; set; }
        public long ProposalId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid TeacherId { get; set; }

    }
}
