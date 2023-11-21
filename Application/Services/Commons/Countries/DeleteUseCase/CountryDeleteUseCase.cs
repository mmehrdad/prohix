using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Countries.DeleteUseCase
{
    public class CountryDeleteUseCase : ICountryDeleteUseCase
    {
        private readonly ICountryRepository _countryRepository;

        public CountryDeleteUseCase(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<DeleteOutputModel> DeleteCountry(int id)
        {
            var foundEntity = await _countryRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _countryRepository.RemoveAsync(foundEntity);
            var result = await _countryRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "Country deleted successfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}