using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Prohix.Application.Services.Students.Account.ConfirmEmail;
using Prohix.Application.Services.Students.Account.ResetPassword.Models;
using Prohix.Core.Entities.Identity;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Account.ResetPassword
{
    public class StudentResetPasswordUseCase : IStudentResetPasswordUseCase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentResetPasswordUseCase(
            IHttpContextAccessor httpContextAccessor,
            IStudentRepository studentRepository,
            UserManager<User> userManager,
            IMapper mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<DeleteOutputModel> ResetPassword(StudentResetPasswordInputModel inputModel)
        {
            var user = await _userManager.FindByIdAsync(inputModel.Id);
            if (user == null)
               return new DeleteOutputModel { Message= "User not found !!!",HasError=true };

            var resetPassResult = await _userManager.ResetPasswordAsync(user, inputModel.Token, inputModel.Password);
            if (!resetPassResult.Succeeded)
            {
                return new DeleteOutputModel { Message = "Somthing went wrong !!!", HasError = true };
            }
            return new DeleteOutputModel { Message = "Password reset successfully ", HasError = false };
        }

        
    }
}
