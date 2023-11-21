using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Commons.Countries.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Commons.Countries.AddUseCase
{
    public interface ICountryAddUseCase : IScopedDependency
    {
      Task<CountryAddOutputModel> AddCountry(CountryAddInputModel inputModel);  
    }
}