using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Countries.GetUseCase
{
    public class CountryGetUseCase : ICountryGetUseCase
    {
        private readonly ICountryRepository _countryRepository;
        public CountryGetUseCase(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public async Task< IQueryable<Country>> GetCountry()
        {
            var result = _countryRepository.GetAllAsNoTracking();
            return result;
        }
    }
}