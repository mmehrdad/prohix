using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Proposals.ProposalStatuses.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.AddUseCase
{
    public interface IProposalStatusAddUseCase : IScopedDependency
    {
        Task<ProposalStatusAddOutputModel> AddProposalStatus(ProposalStatusAddInputModel inputModel);
    }
}