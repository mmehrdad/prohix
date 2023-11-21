using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.StudentInLanguages.UpdateUseCase.Models
{
    public class StudentInLanguageUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public StudentInLanguageUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}