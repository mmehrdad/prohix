using Prohix.Core.Constants.Proposal;
using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.UpdateUseCase.Models
{
    public class ProposalStatusUpdateInputModel : BaseEntity<long>
    {
        public ProposalStatusEnum Status { get; set; }
        public long ProposalId { get; set; }
        public Guid TeacherId { get; set; }

    }
}