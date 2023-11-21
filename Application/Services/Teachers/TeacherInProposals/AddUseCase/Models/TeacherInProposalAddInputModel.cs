using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInProposals.AddUseCase.Models
{
    public class TeacherInProposalAddInputModel
    {
        public long ProposalId { get; set; }
        public Guid TeacherId { get; set; }
    }
}