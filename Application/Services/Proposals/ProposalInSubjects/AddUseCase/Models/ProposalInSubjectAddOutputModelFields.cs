using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalInSubjects.AddUseCase.Models
{
    public class ProposalInSubjectAddOutputModelFields
    {
        public long Id { get; set; }
        public long SubjectId { get; set; }
        public long ProposalId { get; set; }
    }
}