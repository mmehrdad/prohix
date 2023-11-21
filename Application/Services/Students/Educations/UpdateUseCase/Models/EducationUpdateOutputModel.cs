using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Educations.UpdateUseCase.Models
{
    public class EducationUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public EducationUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}