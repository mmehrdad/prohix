using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalInSubjects.AddUseCase.Models
{
    public class ProposalInSubjectAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public ProposalInSubjectAddOutputModelFields OutputModelFields { get; set; } 
    }
}