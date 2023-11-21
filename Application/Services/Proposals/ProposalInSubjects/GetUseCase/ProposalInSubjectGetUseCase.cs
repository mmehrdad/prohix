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

namespace Prohix.Application.Services.Proposals.ProposalInSubjects.GetUseCase
{
    public class ProposalInSubjectGetUseCase : IProposalInSubjectGetUseCase
    {
        private readonly IProposalInSubjectRepository _proposalInSubjectRepository;
        public ProposalInSubjectGetUseCase(IProposalInSubjectRepository proposalInSubjectRepository)
        {
            _proposalInSubjectRepository = proposalInSubjectRepository;
        }
        public IQueryable<ProposalInSubject> GetProposalInSubject()
        {
            var result = _proposalInSubjectRepository.GetAllAsNoTracking();
            return result;
        }
    }
}