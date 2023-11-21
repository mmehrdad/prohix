using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Proposals.Proposals.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Proposals.Proposals.AddUseCase
{
    public interface IProposalAddUseCase : IScopedDependency
    {
      Task<ProposalAddOutputModel> AddProposal(ProposalAddInputModel inputModel);  
    }
}