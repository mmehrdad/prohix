using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Students;
using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.Proposals.AddUseCase.Models
{
    public class ProposalAddInputModel : BaseEntity<long>
    {
        public string Title { get; set; }
        public string PLink { get; set; }
        public Guid StudentId { get; set; }
    }
}