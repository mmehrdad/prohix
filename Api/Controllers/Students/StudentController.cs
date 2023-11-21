using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Prohix.Api.Controllers.Students.Models;
using Prohix.Application.Services.Students.Students.AddUseCase.Models;
using Prohix.Application.Services.Students.Students.AddUseCase;
using Prohix.Application.Services.Students.Students.DeleteUseCase;
using Prohix.Application.Services.Students.Students.GetUseCase;
using Prohix.Application.Services.Students.Students.UpdateUseCase.Models;
using Prohix.Application.Services.Students.Students.UpdateUseCase;
using Prohix.Application.Services;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prohix.Application.Services.Students.Educations.AddUseCase;
using Prohix.Application.Services.Students.Educations.DeleteUseCase;
using Prohix.Application.Services.Students.Educations.GetUseCase;
using Prohix.Application.Services.Students.Educations.UpdateUseCase;
using Prohix.Application.Services.Students.Jobs.AddUseCase;
using Prohix.Application.Services.Students.Jobs.DeleteUseCase;
using Prohix.Application.Services.Students.Jobs.GetUseCase;
using Prohix.Application.Services.Students.Jobs.UpdateUseCase;
using Prohix.Application.Services.Students.StudentInLanguages.AddUseCase;
using Prohix.Application.Services.Students.StudentInLanguages.DeleteUseCase;
using Prohix.Application.Services.Students.StudentInLanguages.GetUseCase;
using Prohix.Application.Services.Students.StudentInLanguages.UpdateUseCase;
using Prohix.Application.Services.Students.Educations.AddUseCase.Models;
using Prohix.Application.Services.Students.Educations.UpdateUseCase.Models;
using Prohix.Application.Services.Students.Jobs.AddUseCase.Models;
using Prohix.Application.Services.Students.Jobs.UpdateUseCase.Models;
using Prohix.Application.Services.Students.StudentInLanguages.AddUseCase.Models;
using Prohix.Application.Services.Students.StudentInLanguages.UpdateUseCase.Models;
using Prohix.Application.Services.Students.Account.Register.Models;
using Prohix.Application.Services.Students.Account.Register;
using Prohix.Application.Services.Students.Account.ConfirmEmail;
using Prohix.Application.Services.Students.Account.ForgotPassword;
using Prohix.Application.Services.Students.Account.ResetPassword;
using Prohix.Application.Services.Students.Account.ResetPassword.Models;
using Prohix.Application.Services.Students.Account.Login;
using Prohix.Application.Services.Students.Account.Login.Models;

namespace Prohix.Api.Controllers.Students
{
    [Route("api/[controller]")]
   // [Authorize]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IMapper _mapper;

        private readonly IStudentUpdateUseCase _studentUpdateUseCase;
        private readonly IStudentAddUseCase _studentAddUseCase;
        private readonly IStudentGetUseCase _studentGetUseCase;
        private readonly IStudentDeleteUseCase _studentDeleteUseCase;

        private readonly IEducationUpdateUseCase _educationUpdateUseCase;
        private readonly IEducationAddUseCase _educationAddUseCase;
        private readonly IEducationGetUseCase _educationGetUseCase;
        private readonly IEducationDeleteUseCase _educationDeleteUseCase;

        private readonly IJobUpdateUseCase _jobUpdateUseCase;
        private readonly IJobAddUseCase _jobAddUseCase;
        private readonly IJobGetUseCase _jobGetUseCase;
        private readonly IJobDeleteUseCase _jobDeleteUseCase;

        private readonly IStudentInLanguageUpdateUseCase _studentInLanguageUpdateUseCase;
        private readonly IStudentInLanguageAddUseCase _studentInLanguageAddUseCase;
        private readonly IStudentInLanguageGetUseCase _studentInLanguageGetUseCase;
        private readonly IStudentInLanguageDeleteUseCase _studentInLanguageDeleteUseCase;

        private readonly IStudentRegisterUseCase _studentRegisterUseCase;
        private readonly IStudentConfirmEmailUseCase _studentConfirmEmailUseCase;
        private readonly IStudentForgotPasswordUseCase _studentForgotPasswordUseCase;
        private readonly IStudentResetPasswordUseCase _studentResetPasswordUseCase;
        private readonly IStudentLoginUseCase _studentLoginUseCase;

        public StudentController(
            IMapper mapper,
            IStudentUpdateUseCase studentUpdateUseCase,
            IStudentAddUseCase studentAddUseCase,
            IStudentGetUseCase studentGetUseCase,
            IStudentDeleteUseCase studentDeleteUseCase,

            IEducationUpdateUseCase educationUpdateUseCase,
            IEducationAddUseCase educationAddUseCase,
            IEducationGetUseCase educationGetUseCase,
            IEducationDeleteUseCase educationDeleteUseCase,

            IJobUpdateUseCase jobUpdateUseCase,
            IJobAddUseCase jobAddUseCase,
            IJobGetUseCase jobGetUseCase,
            IJobDeleteUseCase jobDeleteUseCase,

            IStudentInLanguageUpdateUseCase studentInLanguageUpdateUseCase,
            IStudentInLanguageAddUseCase studentInLanguageAddUseCase,
            IStudentInLanguageGetUseCase studentInLanguageGetUseCase,
            IStudentInLanguageDeleteUseCase studentInLanguageDeleteUseCase,

            IStudentRegisterUseCase studentRegisterUseCase,
            IStudentConfirmEmailUseCase studentConfirmEmailUseCase,
            IStudentForgotPasswordUseCase studentForgotPasswordUseCase,
            IStudentResetPasswordUseCase studentResetPasswordUseCase,
            IStudentLoginUseCase studentLoginUseCase

            )
        {
            _mapper = mapper;
            _studentUpdateUseCase = studentUpdateUseCase;
            _studentAddUseCase = studentAddUseCase;
            _studentGetUseCase = studentGetUseCase;
            _studentDeleteUseCase = studentDeleteUseCase;

            _educationUpdateUseCase = educationUpdateUseCase;
            _educationAddUseCase = educationAddUseCase;
            _educationGetUseCase = educationGetUseCase;
            _educationDeleteUseCase = educationDeleteUseCase;

            _jobUpdateUseCase = jobUpdateUseCase;
            _jobAddUseCase = jobAddUseCase;
            _jobGetUseCase = jobGetUseCase;
            _jobDeleteUseCase = jobDeleteUseCase;

            _studentInLanguageUpdateUseCase = studentInLanguageUpdateUseCase;
            _studentInLanguageAddUseCase = studentInLanguageAddUseCase;
            _studentInLanguageGetUseCase = studentInLanguageGetUseCase;
            _studentInLanguageDeleteUseCase = studentInLanguageDeleteUseCase;

            _studentRegisterUseCase = studentRegisterUseCase;
            _studentConfirmEmailUseCase = studentConfirmEmailUseCase;
            _studentForgotPasswordUseCase = studentForgotPasswordUseCase;
            _studentResetPasswordUseCase = studentResetPasswordUseCase;
            _studentLoginUseCase = studentLoginUseCase;

        }

        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent([FromBody] StudentAddBindingModel bindingModel)
        {
            var output = await _studentAddUseCase.AddStudent(_mapper.Map<StudentAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<StudentAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateStudent")]
        public async Task<IActionResult> UpdateStudent([FromBody] StudentUpdateBindingModel bindingModel)
        {
            var output = await _studentUpdateUseCase.UpdateStudent(_mapper.Map<StudentUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<StudentUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetStudent")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<Student>> GetStudent()
        {
            return _studentGetUseCase.GetStudent();

        }
        [HttpGet("GetStudentById/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<Student> GetStudentById(Guid Id)
        {
            return await _studentGetUseCase.Get_Student_By_Id(Id);

        }
        [HttpGet("DeleteStudent/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteStudent(Guid Id)
        {
            var output = await _studentDeleteUseCase.DeleteStudent(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }
        //------------------------------------ education --------------------------------------
        [HttpPost("AddEducation")]
        public async Task<IActionResult> AddEducation([FromBody] EducationAddBindingModel bindingModel)
        {
            var output = await _educationAddUseCase.AddEducation(_mapper.Map<EducationAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<EducationAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateEducation")]
        public async Task<IActionResult> UpdateEducation([FromBody] EducationUpdateBindingModel bindingModel)
        {
            var output = await _educationUpdateUseCase.UpdateEducation(_mapper.Map<EducationUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<EducationUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetEducation/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<Education>> GetEducation(Guid Id)
        {
            var result= await _educationGetUseCase.GetEducation(Id);
            return result;

        }
        [HttpGet("DeleteEducation/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteEducation(int Id)
        {
            var output = await _educationDeleteUseCase.DeleteEducation(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }

        //---------------------------------------------------- job --------------------------

        [HttpPost("AddJob")]
        public async Task<IActionResult> AddJob([FromBody] JobAddBindingModel bindingModel)
        {
            var output = await _jobAddUseCase.AddJob(_mapper.Map<JobAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<JobAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateJob")]
        public async Task<IActionResult> UpdateJob([FromBody] JobUpdateBindingModel bindingModel)
        {
            var output = await _jobUpdateUseCase.UpdateJob(_mapper.Map<JobUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<JobUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetJob/Id")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<Job>> GetJob(Guid Id)
        {
            return await _jobGetUseCase.GetJob(Id);

        }
        [HttpGet("DeleteJob/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteJob(int Id)
        {
            var output = await _jobDeleteUseCase.DeleteJob(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }

        //------------------------------------------------ language ---------------------------------------

        [HttpPost("AddStudentInLanguage")]
        public async Task<IActionResult> AddStudentInLanguage([FromBody] StudentInLanguageAddBindingModel bindingModel)
        {
            var output = await _studentInLanguageAddUseCase.AddStudentInLanguage(_mapper.Map<StudentInLanguageAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<StudentInLanguageAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateStudentInLanguage")]
        public async Task<IActionResult> UpdateStudentInLanguage([FromBody] StudentInLanguageUpdateBindingModel bindingModel)
        {
            var output = await _studentInLanguageUpdateUseCase.UpdateStudentInLanguage(_mapper.Map<StudentInLanguageUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<StudentInLanguageUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetStudentInLanguage/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<StudentInLanguage>> GetStudentInLanguage(Guid Id)
        {
            return await _studentInLanguageGetUseCase.GetLanguage(Id);

        }
        [HttpGet("DeleteStudentInLanguage/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteStudentInLanguage(int Id)
        {
            var output = await _studentInLanguageDeleteUseCase.DeleteStudentInLanguage(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }
        //------------------------------------------------ Account ---------------------------------------
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] StudentRegisterBindingModel bindingModel)
        {
            bindingModel.IsActive = false;
            bindingModel.IsRemoved= false;
            var output = await _studentRegisterUseCase.RegisterStudent(_mapper.Map<StudentRegisterInputModel>(bindingModel));

            if (output.HasError)
                return Ok(output);

            return Ok(_mapper.Map<StudentRegisterViewModel>(output.OutputModelFields));
        }
        [HttpGet("Confirmemail/{Id}/{Token}")]
        public async Task<IActionResult> Confirmemail(string Id,string Token)
        {
            var result= await _studentConfirmEmailUseCase.ConfirmEmail(Id,Token);

            if (result.HasError)
                return BadRequest(result.Message);

            return Ok(result);
        }
        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] string Email)
        {
           var result= await _studentForgotPasswordUseCase.ForgotPassword(Email);

            if (result.HasError)
                return BadRequest(result.Message);

            return Ok(result);
        }
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] StudentResetPasswordBindingModel bindingModel)
        {
           var result= await _studentResetPasswordUseCase.ResetPassword(_mapper.Map<StudentResetPasswordInputModel>(bindingModel));

            if (result.HasError)
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] StudentLoginBindingModel bindingModel)
        {
            var result = await _studentLoginUseCase.LoginStudent(_mapper.Map<StudentLoginInputModel>(bindingModel));

            //if (result.HasError)
            //    return BadRequest(result.Message);

            return Ok(_mapper.Map<StudentLoginViewModel>(result));
        }
    }
}