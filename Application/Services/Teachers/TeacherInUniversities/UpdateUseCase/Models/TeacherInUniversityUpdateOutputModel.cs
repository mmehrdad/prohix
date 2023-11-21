using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInUniversities.UpdateUseCase.Models
{
    public class TeacherInUniversityUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public TeacherInUniversityUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}