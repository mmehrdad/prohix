using Prohix.Core.Entities.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.GetUseCase
{
    public interface IProposalStatusGetUseCase
    {
        IQueryable<ProposalStatus> GetProposalStatus();
    }
}