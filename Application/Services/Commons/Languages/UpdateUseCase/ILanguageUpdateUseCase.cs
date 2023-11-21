using Prohix.Application.Services.Commons.Languages.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Languages.UpdateUseCase
{
    public interface ILanguageUpdateUseCase: IScopedDependency
    {
        Task<LanguageUpdateOutputModel> UpdateLanguage(LanguageUpdateInputModel inputModel);  
    }
}