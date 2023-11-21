using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Proposals.ProposalInSubjects.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Proposals.ProposalInSubjects.AddUseCase
{
    public interface IProposalInSubjectAddUseCase : IScopedDependency
    {
      Task<ProposalInSubjectAddOutputModel> AddProposalInSubject(ProposalInSubjectAddInputModel inputModel);  
    }
}