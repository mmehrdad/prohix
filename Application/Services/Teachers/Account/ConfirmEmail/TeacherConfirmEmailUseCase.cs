using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Prohix.Application.Services.Teachers.Account.ConfirmEmail;
using Prohix.Core.Entities.Identity;
using Prohix.Core.Entities.Students;
using Prohix.Core.Entities.Teachers;
using Prohix.Infrastracture.RepositoryInterfaces.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Account.ConfirmEmail
{
    public class TeacherConfirmEmailUseCase : ITeacherConfirmEmailUseCase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public TeacherConfirmEmailUseCase(
            IHttpContextAccessor httpContextAccessor,
            ITeacherRepository teacherRepository,
            UserManager<User> userManager,
            IMapper mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }
        public async Task<DeleteOutputModel> ConfirmEmail(string Id, string Token)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null)
                return new DeleteOutputModel { HasError = true, Message = "User not found !!" };

            var token = Encoding.UTF8.GetString(Convert.FromBase64String(Token));

            var result = await _userManager.ConfirmEmailAsync(user, token);

            if (result.Succeeded)
            {
                return new DeleteOutputModel { HasError = false, Message = "Email Confirmed !!" };
            }

            return new DeleteOutputModel { HasError = true, Message = "Invalid Token !!" };
        }
    }
}
