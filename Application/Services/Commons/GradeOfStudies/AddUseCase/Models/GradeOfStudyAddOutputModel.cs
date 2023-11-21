using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.GradeOfStudies.AddUseCase.Models
{
    public class GradeOfStudyAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public GradeOfStudyAddOutputModelFields OutputModelFields { get; set; } 
    }
}