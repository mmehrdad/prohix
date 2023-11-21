using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.GradeOfStudies.DeleteUseCase
{
    public interface IGradeOfStudyDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteGradeOfStudy(int Id); 
    }
}