using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Countries.DeleteUseCase
{
    public interface ICountryDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteCountry(int Id); 
    }
}