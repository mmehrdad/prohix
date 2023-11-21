using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Teachers.Models
{
    public class TeacherInProposalUpdateViewModel
    {
        public long Id { get; set; }
        public long ProposalId { get; set; }
        public Guid TeacherId { get; set; }
    }
}