using Prohix.Application.Services.Commons.Countries.AddUseCase.Models;
using Prohix.Application.Services.Commons.Countries.AddUseCase;
using Prohix.Application.Services.Helper;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using Prohix.Application.Services.Proposals.Proposals.AddUseCase.Models;
using Prohix.Core.Entities.Proposals;

namespace Prohix.Application.Services.Proposals.Proposals.AddUseCase
{
    public class ProposalAddUseCase : IProposalAddUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly IProposalRepository _proposalRepository;

        public ProposalAddUseCase(

            IUserInformationProvider userInformationProvider,
            IProposalRepository proposalRepository,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _proposalRepository = proposalRepository;
            _mapper = mapper;
        }

        public async Task<ProposalAddOutputModel> AddProposal(ProposalAddInputModel inputModel)
        {
            var newProposal = _mapper.Map<Proposal>(inputModel);

            inputModel.CreatedTime = DateTime.Now.Date;
            inputModel.StudentId = userInformationProvider.CurrentUserId;

            await _proposalRepository.AddAsync(newProposal);

            var result = _proposalRepository.SaveChanges();
            if (result > 0)
                return new ProposalAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<ProposalAddOutputModelFields>(newProposal)
                };

            return new ProposalAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}