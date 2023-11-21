using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Proposals.Models
{
    public class ProposalInSubjectUpdateViewModel
    {
        public long Id { get; set; }
        public long SubjectId { get; set; }
        public long ProposalId { get; set; }
    }
}