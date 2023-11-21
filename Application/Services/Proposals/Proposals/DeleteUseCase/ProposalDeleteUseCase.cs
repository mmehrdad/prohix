using Prohix.Application.Services.Commons.Countries.DeleteUseCase;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.Proposals.DeleteUseCase
{
    public class ProposalDeleteUseCase : IProposalDeleteUseCase
    {
        private readonly IProposalRepository _proposalRepository;

        public ProposalDeleteUseCase(IProposalRepository proposalRepository)
        {
            _proposalRepository = proposalRepository;
        }

        public async Task<DeleteOutputModel> DeleteProposal(int id)
        {
            var foundEntity = await _proposalRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _proposalRepository.RemoveAsync(foundEntity);
            var result = await _proposalRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "Proposal deleted successfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}