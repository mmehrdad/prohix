using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Languages.AddUseCase.Models
{
    public class LanguageAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public LanguageAddOutputModelFields OutputModelFields { get; set; } 
    }
}