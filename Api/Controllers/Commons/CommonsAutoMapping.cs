using Prohix.Api.Controllers.Students.Models;
using Prohix.Application.Services.Commons.Universities.AddUseCase.Models;
using Prohix.Application.Utilities;
using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Commons.Models
{
    public class LanguageAutoMapping : DefaultProfile
    {
        public LanguageAutoMapping()
        {
            CreateMap<UniversityAddBindingModel, UniversityAddInputModel>().ReverseMap();
            CreateMap<University, UniversityAddInputModel>().ReverseMap();
            CreateMap<UniversityAddViewModel, UniversityAddOutputModelFields>().ReverseMap();
            CreateMap<University, UniversityAddOutputModelFields>().ReverseMap();
        }
    }
}    