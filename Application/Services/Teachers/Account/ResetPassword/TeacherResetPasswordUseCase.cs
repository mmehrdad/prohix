using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Prohix.Application.Services.Teachers.Account.ResetPassword.Models;
using Prohix.Application.Services.Teachers.Account.ResetPassword;
using Prohix.Infrastracture.RepositoryInterfaces.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Core.Entities.Teachers;
using Prohix.Core.Entities.Students;
using Prohix.Core.Entities.Identity;

namespace Prohix.Application.Services.Teachers.Account.ResetPassword
{
    public class TeacherResetPasswordUseCase : ITeacherResetPasswordUseCase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly ITeacherRepository _teacherRepository;

        public TeacherResetPasswordUseCase(
            IHttpContextAccessor httpContextAccessor,
            ITeacherRepository teacherRepository,
            UserManager<User> userManager
            )
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _teacherRepository = teacherRepository;
        }

        public async Task<DeleteOutputModel> ResetPassword(TeacherResetPasswordInputModel inputModel)
        {
            var user = await _userManager.FindByIdAsync(inputModel.Id);
            if (user == null)
                return new DeleteOutputModel { Message = "User not found !!!", HasError = true };

            var resetPassResult = await _userManager.ResetPasswordAsync(user, inputModel.Token, inputModel.Password);
            if (!resetPassResult.Succeeded)
            {
                return new DeleteOutputModel { Message = "Somthing went wrong !!!", HasError = true };
            }
            return new DeleteOutputModel { Message = "Password reset successfully ", HasError = false };
        }


    }
}
