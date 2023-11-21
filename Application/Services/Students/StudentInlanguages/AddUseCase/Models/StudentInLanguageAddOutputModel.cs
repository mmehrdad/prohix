using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.StudentInLanguages.AddUseCase.Models
{
    public class StudentInLanguageAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public StudentInLanguageAddOutputModelFields OutputModelFields { get; set; } 
    }
}