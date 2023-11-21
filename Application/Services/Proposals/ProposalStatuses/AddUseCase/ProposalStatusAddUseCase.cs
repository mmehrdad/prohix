using AutoMapper;
using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Proposals.ProposalStatuses.AddUseCase.Models;
using Prohix.Core.Entities.Proposals;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalStatuses.AddUseCase
{
    public class ProposalStatusAddUseCase : IProposalStatusAddUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly IProposalStatusRepository _proposalStatusRepository;

        public ProposalStatusAddUseCase(

            IUserInformationProvider userInformationProvider,
            IProposalStatusRepository proposalStatusRepository,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _proposalStatusRepository = proposalStatusRepository;
            _mapper = mapper;
        }

        public async Task<ProposalStatusAddOutputModel> AddProposalStatus(ProposalStatusAddInputModel inputModel)
        {
            var newProposalStatus = _mapper.Map<ProposalStatus>(inputModel);

            inputModel.CreatedTime = DateTime.Now.Date;
            // inputModel.StudentId = userInformationProvider.CurrentUserId;

            await _proposalStatusRepository.AddAsync(newProposalStatus);

            var result = _proposalStatusRepository.SaveChanges();
            if (result > 0)
                return new ProposalStatusAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<ProposalStatusAddOutputModelFields>(newProposalStatus)
                };

            return new ProposalStatusAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}