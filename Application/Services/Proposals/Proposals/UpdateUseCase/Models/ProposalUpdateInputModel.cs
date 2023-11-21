using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.Proposals.UpdateUseCase.Models
{
    public class ProposalUpdateInputModel : BaseEntity<long>
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string PLink { get; set; }
        public Guid StudentId { get; set; }
    }
}