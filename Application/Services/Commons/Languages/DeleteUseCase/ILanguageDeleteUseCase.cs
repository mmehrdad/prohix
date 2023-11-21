using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Languages.DeleteUseCase
{
    public interface ILanguageDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteLanguage(int Id); 
    }
}