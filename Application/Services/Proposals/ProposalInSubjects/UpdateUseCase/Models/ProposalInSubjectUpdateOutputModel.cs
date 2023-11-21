using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalInSubjects.UpdateUseCase.Models
{
    public class ProposalInSubjectUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public ProposalInSubjectUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}