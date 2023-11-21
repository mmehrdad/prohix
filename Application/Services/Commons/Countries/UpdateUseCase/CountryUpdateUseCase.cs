using AutoMapper;
using Prohix.Application.Services.Commons.Countries.UpdateUseCase.Models;
using Prohix.Application.Services.Helper;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Countries.UpdateUseCase
{
    public class CountryUpdateUseCase : ICountryUpdateUseCase
    {
        private readonly IMapper _mapper;
        private readonly ICountryRepository _countryRepository;

        public CountryUpdateUseCase(

            ICountryRepository countryRepository,
            IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }
        public async Task<CountryUpdateOutputModel> UpdateCountry(CountryUpdateInputModel inputModel)
        {
            var countryEntity = await _countryRepository.FindAsync(inputModel.Id);
            if (countryEntity == null)
                return new CountryUpdateOutputModel { HasError = true, Message = "Country not found !!" };

            var countryUpForUpdate = _mapper.Map<CountryUpdateInputModel, Country>(inputModel, countryEntity);

            await _countryRepository.UpdateAsync(countryUpForUpdate);

            var result = await _countryRepository.SaveChangesAsync();

            return result > 0 ? new CountryUpdateOutputModel { OutputModelFields = _mapper.Map<CountryUpdateOutputModelFields>(countryUpForUpdate) } :
                                new CountryUpdateOutputModel { HasError = true, Message = "Somthing went wrong !!" };

        }
    }
}