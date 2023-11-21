using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Universities.AddUseCase.Models
{
    public class UniversityAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public UniversityAddOutputModelFields OutputModelFields { get; set; } 
    }
}