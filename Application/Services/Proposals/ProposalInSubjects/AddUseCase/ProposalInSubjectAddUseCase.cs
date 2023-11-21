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
using Prohix.Application.Services.Proposals.ProposalInSubjects.AddUseCase.Models;
using Prohix.Core.Entities.Proposals;

namespace Prohix.Application.Services.Proposals.ProposalInSubjects.AddUseCase
{
    public class ProposalInSubjectAddUseCase : IProposalInSubjectAddUseCase
    {
        private readonly IMapper _mapper;
        private readonly IProposalInSubjectRepository _proposalInSubjectRepository;

        public ProposalInSubjectAddUseCase(

            IProposalInSubjectRepository proposalInSubjectRepository,
            IMapper mapper)
        {
            _proposalInSubjectRepository = proposalInSubjectRepository;
            _mapper = mapper;
        }

        public async Task<ProposalInSubjectAddOutputModel> AddProposalInSubject(ProposalInSubjectAddInputModel inputModel)
        {
            var newProposalInSubject = _mapper.Map<ProposalInSubject>(inputModel);

            await _proposalInSubjectRepository.AddAsync(newProposalInSubject);

            var result = _proposalInSubjectRepository.SaveChanges();
            if (result > 0)
                return new ProposalInSubjectAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<ProposalInSubjectAddOutputModelFields>(newProposalInSubject)
                };

            return new ProposalInSubjectAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}