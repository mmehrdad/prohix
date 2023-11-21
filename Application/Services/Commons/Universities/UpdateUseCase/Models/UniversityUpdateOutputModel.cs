using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Universities.UpdateUseCase.Models
{
    public class UniversityUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public UniversityUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}