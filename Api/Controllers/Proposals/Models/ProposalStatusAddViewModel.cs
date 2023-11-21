using Prohix.Core.Constants.Proposal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Proposals.Models
{
    public class ProposalStatusAddViewModel
    {
        public long Id { get; set; }
        public ProposalStatusEnum Status { get; set; }
        public long ProposalId { get; set; }
        public Guid TeacherId { get; set; }
    }
}