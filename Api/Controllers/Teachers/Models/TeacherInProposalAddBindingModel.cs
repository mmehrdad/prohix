using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Teachers.Models
{
    public class TeacherInProposalAddBindingModel
    {
        public long ProposalId { get; set; }
        public Guid TeacherId { get; set; }
    }
}