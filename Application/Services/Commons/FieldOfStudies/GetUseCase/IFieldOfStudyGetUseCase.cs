using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.FieldOfStudies.GetUseCase
{
    public interface IFieldOfStudyGetUseCase : IScopedDependency
    {
     Task< IQueryable<FieldOfStudy>> GetFieldOfStudy(); 
    }
}