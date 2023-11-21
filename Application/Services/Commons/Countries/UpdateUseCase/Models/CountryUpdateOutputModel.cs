using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Countries.UpdateUseCase.Models
{
    public class CountryUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public CountryUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}