using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Students.UpdateUseCase.Models
{
    public class StudentUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public StudentUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}