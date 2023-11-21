using Prohix.Api.Controllers.Students.Models;
using Prohix.Application.Services.Students.Account.Login.Models;
using Prohix.Application.Services.Students.Account.Register.Models;
using Prohix.Application.Services.Students.Educations.AddUseCase.Models;
using Prohix.Application.Services.Students.Students.UpdateUseCase.Models;
using Prohix.Application.Utilities;
using Prohix.Core.Entities.Identity;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Students
{
    public class StudentAutoMapping : DefaultProfile
    {
        public StudentAutoMapping()
        {
            CreateMap<StudentRegisterBindingModel, StudentRegisterInputModel>().ReverseMap();
            CreateMap<Student, StudentRegisterInputModel>().ReverseMap();
            CreateMap<Student, StudentRegisterOutputModelFields>().ReverseMap();
            CreateMap<User, StudentRegisterInputModel>().ReverseMap();
            CreateMap<StudentRegisterViewModel, StudentRegisterOutputModelFields>().ReverseMap();

            CreateMap<StudentUpdateBindingModel, StudentUpdateInputModel>().ReverseMap();
            CreateMap<Student, StudentUpdateInputModel>().ReverseMap();
            CreateMap<Student, StudentUpdateOutputModelFields>().ReverseMap();
            CreateMap<StudentUpdateViewModel, StudentUpdateOutputModelFields>().ReverseMap();

            CreateMap<StudentLoginBindingModel, StudentLoginInputModel>().ReverseMap();
            CreateMap<StudentLoginOutputModel, StudentLoginViewModel>().ReverseMap();

            CreateMap<EducationAddBindingModel, EducationAddInputModel>().ReverseMap();
            CreateMap<Education, EducationAddInputModel>().ReverseMap();
            CreateMap<EducationAddViewModel, EducationAddOutputModelFields>().ReverseMap();
            CreateMap<Education, EducationAddOutputModelFields>().ReverseMap();
        }
    }
}