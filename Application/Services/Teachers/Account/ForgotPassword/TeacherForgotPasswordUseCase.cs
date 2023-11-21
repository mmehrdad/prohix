using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Prohix.Application.Services.Commons.Publics.EmailService.Models;
using Prohix.Application.Services.Commons.Publics.EmailService;
using Prohix.Application.Services.Teachers.Account.ForgotPassword;
using Prohix.Infrastracture.RepositoryInterfaces.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Core.Entities.Teachers;
using Prohix.Core.Entities.Students;
using Prohix.Core.Entities.Identity;

namespace Prohix.Application.Services.Teachers.Account.ForgotPassword
{
    public class TeacherForgotPasswordUseCase : ITeacherForgotPasswordUseCase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IEmailService _emailService;

        public TeacherForgotPasswordUseCase(
            IHttpContextAccessor httpContextAccessor,
            ITeacherRepository teacherRepository,
            IEmailService emailService,
            UserManager<User> userManager
            )
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _teacherRepository = teacherRepository;
            _emailService = emailService;
        }
        public async Task<DeleteOutputModel> ForgotPassword(string email)
        {


            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return new DeleteOutputModel { Message = "User not found !!!", HasError = true };
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var token1 = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

            var callbackUrl = @$"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/api/Teacher/ResetPassword/{token1}/{user.Id}";
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
