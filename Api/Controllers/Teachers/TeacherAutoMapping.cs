using Prohix.Api.Controllers.Students.Models;
using Prohix.Api.Controllers.Teachers.Models;
using Prohix.Application.Services.Students.Account.Register.Models;
using Prohix.Application.Services.Teachers.Account.Register.Models;
using Prohix.Application.Utilities;
using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Teachers
{
    public class TeacherAutoMapping : DefaultProfile
    {
        public TeacherAutoMapping()
        {
            CreateMap<TeacherRegisterBindingModel, TeacherRegisterInputModel>().ReverseMap();
            CreateMap<Teacher, StudentRegisterInputModel>().ReverseMap();
            // CreateMap<IndustryUnit, StudentRegisterOutputModelFields>().ReverseMap();
            CreateMap<StudentRegisterViewModel, StudentRegisterOutputModelFields>().ReverseMap();
        }
    }
}