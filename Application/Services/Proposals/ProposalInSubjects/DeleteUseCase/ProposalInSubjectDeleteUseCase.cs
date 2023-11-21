using Prohix.Application.Services.Commons.Countries.DeleteUseCase;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalInSubjects.DeleteUseCase
{
    public class ProposalInSubjectDeleteUseCase : IProposalInSubjectDeleteUseCase
    {
        private readonly IProposalInSubjectRepository _proposalInSubjectRepository;

        public ProposalInSubjectDeleteUseCase(IProposalInSubjectRepository proposalInSubjectRepository)
        {
            _proposalInSubjectRepository = proposalInSubjectRepository;
        }

        public async Task<DeleteOutputModel> DeleteProposalInSubject(int id)
        {
            var foundEntity = await _proposalInSubjectRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _proposalInSubjectRepository.RemoveAsync(foundEntity);
            var result = await _proposalInSubjectRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "Data deleted sucessfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}