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
using AutoMapper;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using Prohix.Application.Services.Proposals.ProposalInSubjects.UpdateUseCase.Models;
using Prohix.Core.Entities.Proposals;

namespace Prohix.Application.Services.Proposals.ProposalInSubjects.UpdateUseCase
{
    public class ProposalInSubjectUpdateUseCase : IProposalInSubjectUpdateUseCase
    {
        private readonly IMapper _mapper;
        private readonly IProposalInSubjectRepository _proposalInSubjectRepository;

        public ProposalInSubjectUpdateUseCase(

            IProposalInSubjectRepository proposalInSubjectRepository,
            IMapper mapper)
        {
            _proposalInSubjectRepository = proposalInSubjectRepository;
            _mapper = mapper;
        }
        public async Task<ProposalInSubjectUpdateOutputModel> UpdateProposalInSubject(ProposalInSubjectUpdateInputModel inputModel)
        {
            var proposalInSubjectEntity = await _proposalInSubjectRepository.FindAsync(inputModel.Id);
            if (proposalInSubjectEntity == null)
                return new ProposalInSubjectUpdateOutputModel { HasError = true, Message = "Data not found !!" };

            var proposalInSubjectUpForUpdate = _mapper.Map<ProposalInSubjectUpdateInputModel, ProposalInSubject>(inputModel, proposalInSubjectEntity);

            await _proposalInSubjectRepository.UpdateAsync(proposalInSubjectUpForUpdate);

            var result = await _proposalInSubjectRepository.SaveChangesAsync();

            return result > 0 ? new ProposalInSubjectUpdateOutputModel { OutputModelFields = _mapper.Map<ProposalInSubjectUpdateOutputModelFields>(proposalInSubjectUpForUpdate) } :
                                new ProposalInSubjectUpdateOutputModel { HasError = true, Message = "Somthing went wrong !!" };

        }
    }
}