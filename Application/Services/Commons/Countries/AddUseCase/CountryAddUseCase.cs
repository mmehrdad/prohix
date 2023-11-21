using AutoMapper;
using Prohix.Application.Services.Commons.Countries.AddUseCase.Models;
using Prohix.Application.Services.Helper;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Countries.AddUseCase
{
    public class CountryAddUseCase : ICountryAddUseCase
    {
        private readonly IMapper _mapper;
        private readonly ICountryRepository _countryRepository;

        public CountryAddUseCase(

            ICountryRepository countryRepository,
            IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<CountryAddOutputModel> AddCountry(CountryAddInputModel inputModel)
        {
           var newCountry = _mapper.Map<Country>(inputModel);

            await _countryRepository.AddAsync(newCountry);

            var result = _countryRepository.SaveChanges();
            if (result > 0)
                return new CountryAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<CountryAddOutputModelFields>(newCountry)
                };

            return new CountryAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}