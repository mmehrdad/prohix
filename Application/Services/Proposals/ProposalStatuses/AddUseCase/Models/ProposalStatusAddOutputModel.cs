using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.AddUseCase.Models
{
    public class ProposalStatusAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public ProposalStatusAddOutputModelFields OutputModelFields { get; set; }
    }
}