using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Teachers.UpdateUseCase.Models
{
    public class TeacherUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public TeacherUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}