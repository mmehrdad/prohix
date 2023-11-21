using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.Proposals.UpdateUseCase.Models
{
    public class ProposalUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public ProposalUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}