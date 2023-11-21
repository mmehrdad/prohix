using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.DeleteUseCase
{
    public interface IProposalStatusDeleteUseCase : IScopedDependency
    {
        Task<DeleteOutputModel> DeleteProposalStatus(int Id);
    }
}