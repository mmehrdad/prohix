using Prohix.Application.Services.Commons.Countries.UpdateUseCase.Models;
using Prohix.Application.Services.Commons.Countries.UpdateUseCase;
using Prohix.Application.Services.Helper;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prohix.Application.Services.Commons.Languages.UpdateUseCase.Models;

namespace Prohix.Application.Services.Commons.Languages.UpdateUseCase
{
    public class LanguageUpdateUseCase : ILanguageUpdateUseCase
    {
        private readonly IMapper _mapper;
        private readonly ILanguageRepository _languageRepository;

        public LanguageUpdateUseCase(

            ILanguageRepository languageRepository,
            IMapper mapper)
        {
            _languageRepository = languageRepository;
            _mapper = mapper;
        }
        public async Task<LanguageUpdateOutputModel> UpdateLanguage(LanguageUpdateInputModel inputModel)
        {
            var languageEntity = await _languageRepository.FindAsync(inputModel.Id);
            if (languageEntity == null)
                return new LanguageUpdateOutputModel { HasError = true, Message = "Language not found !!" };

            var languageUpForUpdate = _mapper.Map<LanguageUpdateInputModel, Language>(inputModel, languageEntity);

            await _languageRepository.UpdateAsync(languageUpForUpdate);

            var result = await _languageRepository.SaveChangesAsync();

            return result > 0 ? new LanguageUpdateOutputModel { OutputModelFields = _mapper.Map<LanguageUpdateOutputModelFields>(languageUpForUpdate) } :
                                new LanguageUpdateOutputModel { HasError = true, Message = "Somthing went wrong !!" };

        }
    }
}