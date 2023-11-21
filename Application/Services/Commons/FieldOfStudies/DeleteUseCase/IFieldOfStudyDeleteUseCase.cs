using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.FieldOfStudies.DeleteUseCase
{
    public interface IFieldOfStudyDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteFieldOfStudy(int Id); 
    }
}