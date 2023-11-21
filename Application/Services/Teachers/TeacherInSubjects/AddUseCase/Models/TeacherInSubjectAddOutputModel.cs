using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInSubjects.AddUseCase.Models
{
    public class TeacherInSubjectAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public TeacherInSubjectAddOutputModelFields OutputModelFields { get; set; } 
    }
}