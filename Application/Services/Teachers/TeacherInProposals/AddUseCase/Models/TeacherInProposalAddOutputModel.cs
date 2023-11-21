using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInProposals.AddUseCase.Models
{
    public class TeacherInProposalAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public TeacherInProposalAddOutputModelFields OutputModelFields { get; set; } 
    }
}