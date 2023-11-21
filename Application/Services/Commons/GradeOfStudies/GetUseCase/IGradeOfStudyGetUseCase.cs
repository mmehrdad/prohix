using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.GradeOfStudies.GetUseCase
{
    public interface IGradeOfStudyGetUseCase : IScopedDependency
    {
      IQueryable<GradeOfStudy> GetGradeOfStudy(); 
    }
}