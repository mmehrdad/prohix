using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Languages.UpdateUseCase.Models
{
    public class LanguageUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public LanguageUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}