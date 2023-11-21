using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.Proposals.AddUseCase.Models
{
    public class ProposalAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public ProposalAddOutputModelFields OutputModelFields { get; set; } 
    }
}