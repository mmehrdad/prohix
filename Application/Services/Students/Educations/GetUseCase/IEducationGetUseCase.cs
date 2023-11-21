using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Educations.GetUseCase
{
    public interface IEducationGetUseCase
    {
     Task< IQueryable<Education>> GetEducation(Guid studentId); 
    }
}