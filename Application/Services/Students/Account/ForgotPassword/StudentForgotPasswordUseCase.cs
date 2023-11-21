using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json.Linq;
using Prohix.Application.Services.Commons.Publics.EmailService;
using Prohix.Application.Services.Commons.Publics.EmailService.Models;
using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Students.Account.ConfirmEmail;
using Prohix.Core.Entities.Identity;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Account.ForgotPassword
{
    public class StudentForgotPasswordUseCase : IStudentForgotPasswordUseCase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly IStudentRepository _studentRepository;
        private readonly IEmailService _emailService;

        public StudentForgotPasswordUseCase(
            IHttpContextAccessor httpContextAccessor,
            IStudentRepository studentRepository,
            IEmailService emailService,
            UserManager<User> userManager
            )
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _studentRepository = studentRepository;
            _emailService = emailService;
        }
        public async Task<DeleteOutputModel> ForgotPassword(string email)
        {


            var user = await _userManager.FindByEmailAsync(email);
            
            if (user == null)
            {
                return new DeleteOutputModel { Message = "User not found !!!", HasError = true };
            }
           // var tokenEmail  = SecretHasher.Hash(email);// Convert.ToBase64String(Encoding.UTF8.GetBytes(email));// WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(email));
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var token1 = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

           // var tokenId = Convert.ToBase64String(Encoding.UTF8.GetBytes(user.Id.ToString()));
            var callbackUrl = @$"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/api/Student/ResetPassword/{token1}/{user.Id}";
            await _emailService.SendEmail(new EmailServiceInputModel
            {
                Email = email,
                Subject = "Reset password from ProHix.com",
                Body = $"Please reset your password by <a href='{callbackUrl}'>clicking here</a>."
            });

            return new DeleteOutputModel { Message = "Email sent !!!", HasError = false };
        }
    }
    
}
