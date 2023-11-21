using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.Proposals.AddUseCase.Models
{
    public class ProposalAddOutputModelFields : BaseEntity<long>
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string PLink { get; set; }
        public Guid StudentId { get; set; }
    }
}