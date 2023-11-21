using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Subjects.Subjects.AddUseCase.Models
{
    public class SubjectAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public SubjectAddOutputModelFields OutputModelFields { get; set; } 
    }
}