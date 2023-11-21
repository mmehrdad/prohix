using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Commons.Languages.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Commons.Languages.AddUseCase
{
    public interface ILanguageAddUseCase : IScopedDependency
    {
      Task<LanguageAddOutputModel> AddLanguage(LanguageAddInputModel inputModel);  
    }
}