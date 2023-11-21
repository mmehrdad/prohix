using Prohix.Application.Services.Commons.Countries.DeleteUseCase;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.DeleteUseCase
{
    public class ProposalStatusDeleteUseCase : IProposalStatusDeleteUseCase
    {
        private readonly IProposalStatusRepository _proposalStatusRepository;

        public ProposalStatusDeleteUseCase(IProposalStatusRepository proposalStatusRepository)
        {
            _proposalStatusRepository = proposalStatusRepository;
        }

        public async Task<DeleteOutputModel> DeleteProposalStatus(int id)
        {
            var foundEntity = await _proposalStatusRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _proposalStatusRepository.RemoveAsync(foundEntity);
            var result = await _proposalStatusRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "ProposalStatus deleted sucessfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}