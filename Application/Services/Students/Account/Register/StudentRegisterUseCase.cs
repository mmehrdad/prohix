using Microsoft.AspNetCore.Identity;
using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Students.Students.AddUseCase.Models;
using Prohix.Application.Services.Students.Students.AddUseCase;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prohix.Application.Services.Students.Account.Register.Models;
using Azure.Core;
using Microsoft.AspNetCore.WebUtilities;
using System.Text.Encodings.Web;
using Prohix.Application.Services.Commons.Publics.EmailService;
using Prohix.Application.Services.Commons.Publics.EmailService.Models;
using Microsoft.IdentityModel.Protocols;
using Microsoft.AspNetCore.Http;
using System.Numerics;
using Prohix.Core.Entities.Identity;
using Prohix.Infrastracture.Repositories.Students;
using Prohix.Core.Constants.Commons;

namespace Prohix.Application.Services.Students.Account.Register
{
    public class StudentRegisterUseCase : IStudentRegisterUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IEmailService _emailService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public StudentRegisterUseCase(

            IUserInformationProvider userInformationProvider,
            IStudentRepository studentRepository,
            UserManager<User> userManager,
            RoleManager<Role> roleManager,
            IEmailService emailService,
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _studentRepository = studentRepository;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _emailService = emailService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<StudentRegisterOutputModel> RegisterStudent(StudentRegisterInputModel inputModel)
        {

            var newStudent = new Student();
            

            var newUser = _mapper.Map<User>(inputModel);
            newUser.UserName = inputModel.Email;
            newUser.CreatedTime = DateTime.Now;

            newUser.Student= newStudent;
            var errorMessage = "";

            var result = await _userManager.CreateAsync(newUser, inputModel.Password);

            var s = @$"{_httpContextAccessor.HttpContext.Request.Scheme}:/{_httpContextAccessor.HttpContext.Request.Host}{_httpContextAccessor.HttpContext.Request.Path}{_httpContextAccessor.HttpContext.Request.QueryString}";
            var scheme = _httpContextAccessor.HttpContext.Request.Scheme;//http
            var host = _httpContextAccessor.HttpContext.Request.Host;//localhost:5115
            var path = _httpContextAccessor.HttpContext.Request.Path;///api/Student/Register
            var querystring = _httpContextAccessor.HttpContext.Request.QueryString;

            if (result.Succeeded)
            {

                //var token = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);

                

                //var roleresult = await _userManager.AddToRoleAsync(newUser, "Student");

                //if(!roleresult.Succeeded)
                //{
                //    return new StudentRegisterOutputModel { HasError = true, Message = "Role not assign to user !!!" };
                //}

                //var token1 = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));


                //var callbackUrl = @$"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/api/Student/ConfirmEmail/{newUser.Id}/{token1}";
                //const string url = "Student/Account/ConfirmEmail";

               
                //await _emailService.SendEmail(new EmailServiceInputModel 
                //{ 
                //    Email=inputModel.Email,
                //    Subject="Confirm your email from ProHix.com",
                //    Body= $"Please confirm your account by <a href='{callbackUrl}'>clicking here</a>." 
                //});

                return new StudentRegisterOutputModel
                {
                    HasError = false,
                    Message="Student successfully registered",
                    OutputModelFields = _mapper.Map<StudentRegisterOutputModelFields>(newStudent)
                };
            }
            switch (result.Errors.FirstOrDefault().Code)
            {
                case "DefaultError":
                    errorMessage = "Somthing went wrong !";break;
                case "DuplicateUserName":
                    errorMessage = "Username already exist !"; break;
                case "DuplicateEmail":
                    errorMessage = "Email already exist !"; break;
                case "InvalidEmail":
                    errorMessage = "Email not valid !"; break;
                case "InvalidUserName":
                    errorMessage = "Username not valid !"; break;
                case "PasswordTooShort":
                    errorMessage = "Password is Too Short !"; break;
                case "PasswordRequiresNonAlphanumeric":
                    errorMessage = "Password Requires Non Alphanumeric !"; break;
                case "PasswordRequiresUniqueChars":
                    errorMessage = "Password Requires Unique Chars !"; break;
            }
            return new StudentRegisterOutputModel { HasError = true, Message = errorMessage };
        }
    }
}
