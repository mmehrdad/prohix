using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Countries.AddUseCase.Models
{
    public class CountryAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public CountryAddOutputModelFields OutputModelFields { get; set; } 
    }
}