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

namespace Prohix.Application.Services.Proposals.Proposals.GetUseCase
{
    public class ProposalGetUseCase : IProposalGetUseCase
    {
        private readonly IProposalRepository _proposalRepository;
        public ProposalGetUseCase(IProposalRepository proposalRepository)
        {
            _proposalRepository = proposalRepository;
        }
        public IQueryable<Proposal> GetProposal()
        {
            var result = _proposalRepository.GetAllAsNoTracking();
            return result;
        }
    }
}