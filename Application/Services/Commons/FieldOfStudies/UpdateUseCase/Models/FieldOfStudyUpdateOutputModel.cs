using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.FieldOfStudies.UpdateUseCase.Models
{
    public class FieldOfStudyUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public FieldOfStudyUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}