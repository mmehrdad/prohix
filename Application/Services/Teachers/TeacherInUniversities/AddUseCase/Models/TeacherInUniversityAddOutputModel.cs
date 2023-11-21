using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInUniversities.AddUseCase.Models
{
    public class TeacherInUniversityAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public TeacherInUniversityAddOutputModelFields OutputModelFields { get; set; } 
    }
}