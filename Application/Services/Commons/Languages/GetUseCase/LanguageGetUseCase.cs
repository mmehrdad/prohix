using Prohix.Application.Services.Commons.GradeOfStudies.GetUseCase;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Languages.GetUseCase
{
    public class LanguageGetUseCase : ILanguageGetUseCase
    {
        private readonly ILanguageRepository _languageRepository;
        public LanguageGetUseCase(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }
        public async Task< IQueryable<Language>> GetLanguage()
        {
            var result = _languageRepository.GetAllAsNoTracking();
            return result;
        }
    }
}