using Prohix.Core.Constants.Proposal;
using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.AddUseCase.Models
{
    public class ProposalStatusAddOutputModelFields : BaseEntity<long>
    {
        public long Id { get; set; }
        public ProposalStatusEnum Status { get; set; }
        public long ProposalId { get; set; }
        public Guid TeacherId { get; set; }

    }
}