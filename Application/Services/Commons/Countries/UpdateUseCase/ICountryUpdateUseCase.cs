using Prohix.Application.Services.Commons.Countries.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Countries.UpdateUseCase
{
    public interface ICountryUpdateUseCase: IScopedDependency
    {
      Task<CountryUpdateOutputModel> UpdateCountry(CountryUpdateInputModel inputModel);  
    }
}