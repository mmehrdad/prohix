using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Proposals.Models
{
    public class ProposalUpdateBindingModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string PLink { get; set; }
        public Guid StudentId { get; set; }
    }
}