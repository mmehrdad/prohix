using Prohix.Application.Services.Proposals.Proposals.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.Proposals.UpdateUseCase
{
    public interface IProposalUpdateUseCase: IScopedDependency
    {
      Task<ProposalUpdateOutputModel> UpdateProposal(ProposalUpdateInputModel inputModel);  
    }
}