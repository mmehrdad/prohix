using Prohix.Application.Services.Commons.Countries.AddUseCase.Models;
using Prohix.Application.Services.Commons.Countries.AddUseCase;
using Prohix.Application.Services.Helper;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prohix.Application.Services.Commons.Languages.AddUseCase.Models;

namespace Prohix.Application.Services.Commons.Languages.AddUseCase
{
    public class LanguageAddUseCase : ILanguageAddUseCase
    {
        private readonly IMapper _mapper;
        private readonly ILanguageRepository _countryRepository;

        public LanguageAddUseCase(

            ILanguageRepository countryRepository,
            IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<LanguageAddOutputModel> AddLanguage(LanguageAddInputModel inputModel)
        {
            var newLanguage = _mapper.Map<Language>(inputModel);

            await _countryRepository.AddAsync(newLanguage);

            var result = _countryRepository.SaveChanges();
            if (result > 0)
                return new LanguageAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<LanguageAddOutputModelFields>(newLanguage)
                };

            return new LanguageAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}