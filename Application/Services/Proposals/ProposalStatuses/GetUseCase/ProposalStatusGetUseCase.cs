using Prohix.Application.Services.Commons.Countries.GetUseCase;
using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Proposals;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.GetUseCase
{
    public class ProposalStatusGetUseCase : IProposalStatusGetUseCase
    {
        private readonly IProposalStatusRepository _proposalStatusRepository;
        public ProposalStatusGetUseCase(IProposalStatusRepository proposalStatusRepository)
        {
            _proposalStatusRepository = proposalStatusRepository;
        }
        public IQueryable<ProposalStatus> GetProposalStatus()
        {
            var result = _proposalStatusRepository.GetAllAsNoTracking();
            return result;
        }
    }
}