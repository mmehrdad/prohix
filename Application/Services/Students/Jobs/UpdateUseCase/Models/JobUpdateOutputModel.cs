using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Jobs.UpdateUseCase.Models
{
    public class JobUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public JobUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}