using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Universities.GetUseCase
{
    public interface IUniversityGetUseCase : IScopedDependency
    {
     Task< IQueryable<University>> GetUniversity(long countryId); 
    }
}