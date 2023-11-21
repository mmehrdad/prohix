using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.GradeOfStudies.UpdateUseCase.Models
{
    public class GradeOfStudyUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public GradeOfStudyUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}