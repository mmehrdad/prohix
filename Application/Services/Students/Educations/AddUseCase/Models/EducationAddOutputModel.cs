using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Educations.AddUseCase.Models
{
    public class EducationAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public EducationAddOutputModelFields OutputModelFields { get; set; } 
    }
}