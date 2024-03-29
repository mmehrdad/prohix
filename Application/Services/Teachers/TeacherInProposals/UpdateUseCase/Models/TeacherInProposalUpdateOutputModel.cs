using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInProposals.UpdateUseCase.Models
{
    public class TeacherInProposalUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public TeacherInProposalUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}