using Prohix.Application.Services.Students.Educations.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Educations.UpdateUseCase
{
    public interface IEducationUpdateUseCase
    {
      Task<EducationUpdateOutputModel> UpdateEducation(EducationUpdateInputModel inputModel);  
    }
}