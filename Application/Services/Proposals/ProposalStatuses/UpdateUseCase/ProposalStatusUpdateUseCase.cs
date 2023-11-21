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
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using AutoMapper;
using Prohix.Application.Services.Proposals.ProposalStatuses.UpdateUseCase.Models;
using Prohix.Core.Entities.Proposals;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.UpdateUseCase
{
    public class ProposalStatusUpdateUseCase : IProposalStatusUpdateUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly IProposalStatusRepository _proposalStatusRepository;

        public ProposalStatusUpdateUseCase(

            IUserInformationProvider userInformationProvider,
            IProposalStatusRepository proposalStatusRepository,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _proposalStatusRepository = proposalStatusRepository;
            _mapper = mapper;
        }
        public async Task<ProposalStatusUpdateOutputModel> UpdateProposalStatus(ProposalStatusUpdateInputModel inputModel)
        {
            var proposalStatusEntity = await _proposalStatusRepository.FindAsync(inputModel.Id);
            if (proposalStatusEntity == null)
                return new ProposalStatusUpdateOutputModel { HasError = true, Message = "ProposalStatus not found !!" };

            var proposalStatusUpForUpdate = _mapper.Map<ProposalStatusUpdateInputModel, ProposalStatus>(inputModel, proposalStatusEntity);

            await _proposalStatusRepository.UpdateAsync(proposalStatusUpForUpdate);

            var result = await _proposalStatusRepository.SaveChangesAsync();

            return result > 0 ? new ProposalStatusUpdateOutputModel { OutputModelFields = _mapper.Map<ProposalStatusUpdateOutputModelFields>(proposalStatusUpForUpdate) } :
                                new ProposalStatusUpdateOutputModel { HasError = true, Message = "Somthing went wrong !!" };

        }
    }
}