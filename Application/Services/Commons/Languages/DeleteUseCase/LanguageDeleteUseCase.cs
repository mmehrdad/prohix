using Prohix.Application.Services.Commons.Countries.DeleteUseCase;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Languages.DeleteUseCase
{
    public class LanguageDeleteUseCase : ILanguageDeleteUseCase
    {
        private readonly ILanguageRepository _languageRepository;

        public LanguageDeleteUseCase(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public async Task<DeleteOutputModel> DeleteLanguage(int id)
        {
            var foundEntity = await _languageRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _languageRepository.RemoveAsync(foundEntity);
            var result = await _languageRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "Language deleted sucessfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}