using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Proposals;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.RepositoryInterfaces.Commons
{
    public interface IUniversityRepository : IBaseRepository<University>, IScopedDependency
    {
         Task<IQueryable<University>> Get_By_TeacherId(Guid teacherId);
        Task<IQueryable<University>> Get_By_CountryId(long countryId);
    }
}
