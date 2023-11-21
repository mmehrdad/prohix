using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInSubjects.UpdateUseCase.Models
{
    public class TeacherInSubjectUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public TeacherInSubjectUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}