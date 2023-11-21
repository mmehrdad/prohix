using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json.Linq;
using Prohix.Application.Services.Students.Students.UpdateUseCase.Models;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.Repositories.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using Prohix.Core.Entities.Identity;

namespace Prohix.Application.Services.Students.Account.ConfirmEmail
{
    public class StudentConfirmEmailUseCase : IStudentConfirmEmailUseCase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        

        public StudentConfirmEmailUseCase(
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
        public async Task<DeleteOutputModel> ConfirmEmail(string Id, string Token)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null)
                return new DeleteOutputModel { HasError = true, Message = "User not found !!" }; ;

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
