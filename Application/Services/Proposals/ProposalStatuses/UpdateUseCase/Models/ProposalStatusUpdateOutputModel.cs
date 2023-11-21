using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.UpdateUseCase.Models
{
    public class ProposalStatusUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public ProposalStatusUpdateOutputModelFields OutputModelFields { get; set; }
    }
}