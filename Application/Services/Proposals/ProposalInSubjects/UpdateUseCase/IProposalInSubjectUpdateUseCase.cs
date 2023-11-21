using Prohix.Application.Services.Proposals.ProposalInSubjects.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalInSubjects.UpdateUseCase
{
    public interface IProposalInSubjectUpdateUseCase: IScopedDependency
    {
      Task<ProposalInSubjectUpdateOutputModel> UpdateProposalInSubject(ProposalInSubjectUpdateInputModel inputModel);  
    }
}