using Prohix.Application.Services.Proposals.ProposalStatuses.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.UpdateUseCase
{
    public interface IProposalStatusUpdateUseCase : IScopedDependency
    {
        Task<ProposalStatusUpdateOutputModel> UpdateProposalStatus(ProposalStatusUpdateInputModel inputModel);
    }
}