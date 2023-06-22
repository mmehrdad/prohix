using Prohix.Core.Constants.Proposal;
using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Proposals
{
    public class ProposalStatus:BaseEntity<long>
    {
        public ProposalStatuses Status { get; set; }
        public Proposal Proposal { get; set; }
        public long ProposalId { get; set; }

    }
}
