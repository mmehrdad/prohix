using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Prohix.Application.Services.Commons.Publics.EmailService.Models;
using Prohix.Application.Services.Commons.Publics.EmailService;
using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Students.Account.Login.Models;
using Prohix.Application.Services.Students.Account.Login;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Core.Entities.Students;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using Prohix.Infrastracture.Utilities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Prohix.Core.Entities.Identity;
using Prohix.Application.Services.Teachers.Account.Login.Models;
using Prohix.Infrastracture.RepositoryInterfaces.Identity;
using Microsoft.EntityFrameworkCore;

namespace Prohix.Application.Services.Students.Account.Login
{
    public class StudentLoginUseCase : IStudentLoginUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        private readonly IUserRepository _userRepository;
        private readonly UserManager<User> _userManager;
       // private readonly SignInManager<User> _signInManager;
        private readonly IEmailService _emailService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public StudentLoginUseCase(

            IUserInformationProvider userInformationProvider,
            IStudentRepository studentRepository,
            IUserRepository userRepository,
            UserManager<User> userManager,
            IEmailService emailService,
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _studentRepository = studentRepository;
            _userRepository = userRepository;
            _mapper = mapper;
            _userManager = userManager;
            _emailService = emailService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<StudentLoginOutputModel> LoginStudent(StudentLoginInputModel inputModel)
        {
            var user = _userManager.FindByEmailAsync(inputModel.Username).Result;
            
            if (user == null)
            {
                return new StudentLoginOutputModel { HasError = true, Message = "User not found !!!" };
            }
            if (user.IsActive == false)
            {
                return new StudentLoginOutputModel { HasError = true, Message = "User not active !!!" };
            }
            if (user.EmailConfirmed == false)
            {
                return new StudentLoginOutputModel { HasError = true, Message = "Email not confirmed !!!" };
            }
            var rol = _userManager.GetRolesAsync(user).Result;
            if (rol.Count > 0)
            {
                if (rol[0].ToString() != "Student")
                {
                    return new StudentLoginOutputModel { HasError = true, Message = "Access denied !!!" };
                }
            }
           // var result = _signInManager.PasswordSignInAsync(user, inputModel.Password, true , true).Result;
           // var result =await _userManager.CheckPasswordAsync(user, inputModel.Password);

            if ( _userManager.CheckPasswordAsync(user, inputModel.Password).Result)
            {
                return new StudentLoginOutputModel { HasError = true, Message = "Wrong password !!!" };
            }

            var userRoles = await _userManager.GetRolesAsync(user);

            if (userRoles.Count == 0)
            {
                return new StudentLoginOutputModel { HasError = true, Message = "Role not set for user !!!" };
            }

            if (!userRoles.Contains("Student"))
            {
                return new StudentLoginOutputModel { HasError = true, Message = "User not access to this section !!!" };
            }

            // user.Include(p=>p.)
           var stu= _userRepository.GetAllAsNoTracking().Where(p => p.Id == user.Id).Include(p => p.Student).FirstOrDefaultAsync().Result;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(AppConfig.GetSection("JwtSettings", "Secret"));

            //var encryptionKey = RSA.Create(3072);
            //var signingKey = ECDsa.Create(ECCurve.NamedCurves.nistP256);
            

            var claims = new List<Claim>();
            claims.Add(new Claim("UserId", user.Id.ToString()));
            claims.Add(new Claim("Name", stu.Student.FirstName+" "+stu.Student.Surname));
            claims.Add(new Claim("UserName", user.UserName));
            claims.Add(new Claim("Role", "Student"));
            claims.Add(new Claim("StudentId", user.StudentId.ToString()));


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
            return new StudentLoginOutputModel
            {
                HasError = false,
                Message = "Successfully loged in",
                Token = tokenString,
               // UserName = user.Student.FirstName + " " + user.Student.SureName,

            };
        }
    }
}
