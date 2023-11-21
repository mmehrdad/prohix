using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Teachers.AddUseCase.Models
{
    public class TeacherAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public TeacherAddOutputModelFields OutputModelFields { get; set; } 
    }
}