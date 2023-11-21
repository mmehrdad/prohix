using Prohix.Application.Services.Commons.Countries.UpdateUseCase.Models;
using Prohix.Application.Services.Commons.Countries.UpdateUseCase;
using Prohix.Application.Services.Helper;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Proposals.Proposals.UpdateUseCase.Models;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using AutoMapper;
using Prohix.Core.Entities.Proposals;

namespace Prohix.Application.Services.Proposals.Proposals.UpdateUseCase
{
    public class ProposalUpdateUseCase : IProposalUpdateUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly IProposalRepository _proposalRepository;

        public ProposalUpdateUseCase(

            IUserInformationProvider userInformationProvider,
            IProposalRepository proposalRepository,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _proposalRepository = proposalRepository;
            _mapper = mapper;
        }
        public async Task<ProposalUpdateOutputModel> UpdateProposal(ProposalUpdateInputModel inputModel)
        {
            var proposalEntity = await _proposalRepository.FindAsync(inputModel.Id);
            if (proposalEntity == null)
                return new ProposalUpdateOutputModel { HasError = true, Message = "Proposal not found !!" };

            var proposalUpForUpdate = _mapper.Map<ProposalUpdateInputModel, Proposal>(inputModel, proposalEntity);

            await _proposalRepository.UpdateAsync(proposalUpForUpdate);

            var result = await _proposalRepository.SaveChangesAsync();

            return result > 0 ? new ProposalUpdateOutputModel { OutputModelFields = _mapper.Map<ProposalUpdateOutputModelFields>(proposalUpForUpdate) } :
                                new ProposalUpdateOutputModel { HasError = true, Message = "Somthing went wrong !!" };

        }
    }
}