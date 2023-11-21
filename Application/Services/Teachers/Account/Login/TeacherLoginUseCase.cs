using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Prohix.Application.Services.Commons.Publics.EmailService;
using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Teachers.Account.Login.Models;
using Prohix.Application.Services.Teachers.Account.Login;
using Prohix.Infrastracture.RepositoryInterfaces.Teachers;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Prohix.Core.Entities.Teachers;
using AutoMapper;
using Prohix.Core.Entities.Identity;

namespace Prohix.Application.Services.Teachers.Account.Login
{
    internal class TeacherLoginUseCase : ITeacherLoginUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly ITeacherRepository _teacherRepository;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailService _emailService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TeacherLoginUseCase(

            IUserInformationProvider userInformationProvider,
            ITeacherRepository teacherRepository,
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IEmailService emailService,
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _teacherRepository = teacherRepository;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<TeacherLoginOutputModel> LoginTeacher(TeacherLoginInputModel inputModel)
        {
            var user = _userManager.FindByEmailAsync(inputModel.Username).Result;
            if (user == null)
            {
                return new TeacherLoginOutputModel { HasError = true, Message = "User not found !!!" };
            }
            if (user.IsActive == false)
            {
                return new TeacherLoginOutputModel { HasError = true, Message = "User not active !!!" };
            }
            if (user.EmailConfirmed == false)
            {
                return new TeacherLoginOutputModel { HasError = true, Message = "Email not confirmed !!!" };
            }
            var rol = _userManager.GetRolesAsync(user).Result;
            if (rol[0].ToString() != "Teacher")
            {
                return new TeacherLoginOutputModel { HasError = true, Message = "Access denied !!!" };
            }
            var result = _signInManager.PasswordSignInAsync(user, inputModel.Password, true, true).Result;

            if (!result.Succeeded)
            {
                return new TeacherLoginOutputModel { HasError = true, Message = "Wrong password !!!" };
            }

            var userRoles = await _userManager.GetRolesAsync(user);

            if(userRoles.Count == 0 )
            {
                return new TeacherLoginOutputModel { HasError = true, Message = "Role not set for user !!!" };
            }

            if (!userRoles.Contains("Teacher"))
            {
                return new TeacherLoginOutputModel { HasError = true, Message = "User not access to this section !!!" };
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(AppConfig.GetSection("JwtSettings", "Secret"));

            var encryptionKey = RSA.Create(3072);
            var signingKey = ECDsa.Create(ECCurve.NamedCurves.nistP256);


            var claims = new List<Claim>();
            claims.Add(new Claim("UserId", user.Id.ToString()));
           // claims.Add(new Claim("Name", user.Teacher.FirstName + " " + user.Teacher.SureName));
            claims.Add(new Claim("UserName", user.UserName));
            claims.Add(new Claim("Role", "Teacher"));


            foreach (var userRole in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {

                Expires = DateTime.UtcNow.AddDays(double.Parse(AppConfig.GetSection("JwtSettings", "TokenExpireTime"))),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),

                Issuer = AppConfig.GetSection("JwtSettings", "Issuer"),
                Audience = AppConfig.GetSection("JwtSettings", "Audience"),
                Subject = new ClaimsIdentity(claims),
            };


            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return new TeacherLoginOutputModel
            {
                HasError = false,
                Message = "Successfully loged in",
                Token = tokenString,
               // UserName = user.Teacher.FirstName + " " + user.Teacher.SureName,

            };
        }
    }
}
