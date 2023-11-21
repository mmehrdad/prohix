using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Jobs.AddUseCase.Models
{
    public class JobAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public JobAddOutputModelFields OutputModelFields { get; set; } 
    }
}