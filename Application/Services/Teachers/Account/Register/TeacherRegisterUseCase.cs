using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Prohix.Application.Services.Commons.Publics.EmailService.Models;
using Prohix.Application.Services.Commons.Publics.EmailService;
using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Teachers.Account.Register.Models;
using Prohix.Application.Services.Teachers.Account.Register;
using Prohix.Infrastracture.RepositoryInterfaces.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Core.Entities.Teachers;
using AutoMapper;
using Prohix.Application.Services.Teachers.Account.Register.Models;
using Prohix.Core.Entities.Students;
using Prohix.Core.Entities.Identity;
using Prohix.Application.Services.Students.Account.Register.Models;

namespace Prohix.Application.Services.Teachers.Account.Register
{
    public class TeacherRegisterUseCase : ITeacherRegisterUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly ITeacherRepository _teacherRepository;
        private readonly UserManager<User> _userManager;
        private readonly IEmailService _emailService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TeacherRegisterUseCase(

            IUserInformationProvider userInformationProvider,
            ITeacherRepository teacherRepository,
            UserManager<User> userManager,
            IEmailService emailService,
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _teacherRepository = teacherRepository;
            _mapper = mapper;
            _userManager = userManager;
            _emailService = emailService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<TeacherRegisterOutputModel> RegisterTeacher(TeacherRegisterInputModel inputModel)
        {
            var newTeacher = new Teacher();
            

            var newUser = _mapper.Map<User>(inputModel);
            newUser.UserName = inputModel.Email;
            newUser.CreatedTime = DateTime.Now;

            newUser.Teacher = newTeacher;
            var result = await _userManager.CreateAsync(newUser, inputModel.Password);

            //  await _teacherRepository.AddAsync(newTeacher);
            var s = @$"{_httpContextAccessor.HttpContext.Request.Scheme}:/{_httpContextAccessor.HttpContext.Request.Host}{_httpContextAccessor.HttpContext.Request.Path}{_httpContextAccessor.HttpContext.Request.QueryString}";
            var scheme = _httpContextAccessor.HttpContext.Request.Scheme;//http
            var host = _httpContextAccessor.HttpContext.Request.Host;//localhost:5115
            var path = _httpContextAccessor.HttpContext.Request.Path;///api/Teacher/Register
            var querystring = _httpContextAccessor.HttpContext.Request.QueryString;

            if (result.Succeeded)
            {
                var roleresult =await _userManager.AddToRoleAsync(newUser, "Teacher");


                if (!roleresult.Succeeded)
                {
                    return new TeacherRegisterOutputModel { HasError = true, Message = "Role not assign to user !!!" };
                }

                var token = await _userManager.GenerateEmailConfirmationTokenAsync(newTeacher.User);

                var token1 = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));


                var callbackUrl = @$"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/api/Teacher/ConfirmEmail/{newUser.Id}/{token1}";
                const string url = "Teacher/Account/ConfirmEmail";


                await _emailService.SendEmail(new EmailServiceInputModel
                {
                    Email = inputModel.Email,
                    Subject = "Confirm your email from ProHix.com",
                    Body = $"Please confirm your account by <a href='{callbackUrl}'>clicking here</a>."
                });

                return new TeacherRegisterOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<TeacherRegisterOutputModelFields>(newTeacher)
                };
            }

            return new TeacherRegisterOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}
