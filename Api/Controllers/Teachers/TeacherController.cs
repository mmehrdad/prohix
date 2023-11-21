using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Prohix.Api.Controllers.Teachers.Models;
using Prohix.Application.Services.Teachers.Teachers.AddUseCase.Models;
using Prohix.Application.Services.Teachers.Teachers.UpdateUseCase.Models;
using Prohix.Application.Services;
using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Teachers.TeacherInProposals.AddUseCase.Models;
using Prohix.Application.Services.Teachers.TeacherInProposals.UpdateUseCase.Models;
using Prohix.Application.Services.Teachers.TeacherInSubjects.AddUseCase.Models;
using Prohix.Application.Services.Teachers.TeacherInSubjects.UpdateUseCase.Models;
using Prohix.Application.Services.Teachers.TeacherInUniversities.AddUseCase.Models;
using Prohix.Application.Services.Teachers.TeacherInUniversities.UpdateUseCase.Models;
using Prohix.Application.Services.Teachers.TeacherInProposals.AddUseCase;
using Prohix.Application.Services.Teachers.TeacherInProposals.DeleteUseCase;
using Prohix.Application.Services.Teachers.TeacherInProposals.GetUseCase;
using Prohix.Application.Services.Teachers.TeacherInProposals.UpdateUseCase;
using Prohix.Application.Services.Teachers.TeacherInSubjects.AddUseCase;
using Prohix.Application.Services.Teachers.TeacherInSubjects.DeleteUseCase;
using Prohix.Application.Services.Teachers.TeacherInSubjects.GetUseCase;
using Prohix.Application.Services.Teachers.TeacherInSubjects.UpdateUseCase;
using Prohix.Application.Services.Teachers.TeacherInUniversities.AddUseCase;
using Prohix.Application.Services.Teachers.TeacherInUniversities.DeleteUseCase;
using Prohix.Application.Services.Teachers.TeacherInUniversities.GetUseCase;
using Prohix.Application.Services.Teachers.TeacherInUniversities.UpdateUseCase;
using Prohix.Application.Services.Teachers.Teachers.AddUseCase;
using Prohix.Application.Services.Teachers.Teachers.DeleteUseCase;
using Prohix.Application.Services.Teachers.Teachers.GetUseCase;
using Prohix.Application.Services.Teachers.Teachers.UpdateUseCase;
using AutoMapper;
using Prohix.Application.Services.Teachers.Account.ConfirmEmail;
using Prohix.Application.Services.Teachers.Account.ForgotPassword;
using Prohix.Application.Services.Teachers.Account.Register;
using Prohix.Application.Services.Teachers.Account.ResetPassword;
using Prohix.Api.Controllers.Teachers.Models;
using Prohix.Application.Services.Teachers.Account.Register.Models;
using Prohix.Application.Services.Teachers.Account.ResetPassword.Models;

namespace Prohix.Api.Controllers.Teachers
{
    [Route("api/[controller]")]
    //[Authorize]
    [ApiController]
    public class TeacherController : Controller
    {

        private readonly IMapper _mapper;
        private readonly ITeacherUpdateUseCase _teacherUpdateUseCase;
        private readonly ITeacherAddUseCase _teacherAddUseCase;
        private readonly ITeacherGetUseCase _teacherGetUseCase;
        private readonly ITeacherDeleteUseCase _teacherDeleteUseCase;

        private readonly ITeacherInProposalUpdateUseCase _teacherInProposalUpdateUseCase;
        private readonly ITeacherInProposalAddUseCase _teacherInProposalAddUseCase;
        private readonly ITeacherInProposalGetUseCase _teacherInProposalGetUseCase;
        private readonly ITeacherInProposalDeleteUseCase _teacherInProposalDeleteUseCase;

        private readonly ITeacherInSubjectUpdateUseCase _teacherInSubjectUpdateUseCase;
        private readonly ITeacherInSubjectAddUseCase _teacherInSubjectAddUseCase;
        private readonly ITeacherInSubjectGetUseCase _teacherInSubjectGetUseCase;
        private readonly ITeacherInSubjectDeleteUseCase _teacherInSubjectDeleteUseCase;

        private readonly ITeacherInUniversityUpdateUseCase _teacherInUniversityUpdateUseCase;
        private readonly ITeacherInUniversityAddUseCase _teacherInUniversityAddUseCase;
        private readonly ITeacherInUniversityGetUseCase _teacherInUniversityGetUseCase;
        private readonly ITeacherInUniversityDeleteUseCase _teacherInUniversityDeleteUseCase;

        private readonly ITeacherRegisterUseCase _teacherRegisterUseCase;
        private readonly ITeacherConfirmEmailUseCase _teacherConfirmEmailUseCase;
        private readonly ITeacherForgotPasswordUseCase _teacherForgotPasswordUseCase;
        private readonly ITeacherResetPasswordUseCase _teacherResetPasswordUseCase;


        public TeacherController(
            IMapper mapper,
            ITeacherUpdateUseCase teacherUpdateUseCase,
            ITeacherAddUseCase teacherAddUseCase,
            ITeacherGetUseCase teacherGetUseCase,
            ITeacherDeleteUseCase teacherDeleteUseCase,

            ITeacherInProposalUpdateUseCase teacherInProposalUpdateUseCase,
            ITeacherInProposalAddUseCase teacherInProposalAddUseCase,
            ITeacherInProposalGetUseCase teacherInProposalGetUseCase,
            ITeacherInProposalDeleteUseCase teacherInProposalDeleteUseCase,

            ITeacherInSubjectUpdateUseCase teacherInSubjectUpdateUseCase,
            ITeacherInSubjectAddUseCase teacherInSubjectAddUseCase,
            ITeacherInSubjectGetUseCase teacherInSubjectGetUseCase,
            ITeacherInSubjectDeleteUseCase teacherInSubjectDeleteUseCase,

            ITeacherInUniversityUpdateUseCase teacherInUniversityUpdateUseCase,
            ITeacherInUniversityAddUseCase teacherInUniversityAddUseCase,
            ITeacherInUniversityGetUseCase teacherInUniversityGetUseCase,
            ITeacherInUniversityDeleteUseCase teacherInUniversityDeleteUseCase,

            ITeacherRegisterUseCase teacherRegisterUseCase,
            ITeacherConfirmEmailUseCase teacherConfirmEmailUseCase,
            ITeacherForgotPasswordUseCase teacherForgotPasswordUseCase,
            ITeacherResetPasswordUseCase teacherResetPasswordUseCase)
        {
            _teacherUpdateUseCase = teacherUpdateUseCase;
            _teacherAddUseCase = teacherAddUseCase;
            _teacherGetUseCase = teacherGetUseCase;
            _teacherDeleteUseCase = teacherDeleteUseCase;

            _teacherInProposalUpdateUseCase = teacherInProposalUpdateUseCase;
            _teacherInProposalAddUseCase = teacherInProposalAddUseCase;
            _teacherInProposalGetUseCase = teacherInProposalGetUseCase;
            _teacherInProposalDeleteUseCase = teacherInProposalDeleteUseCase;

            _teacherInSubjectUpdateUseCase = teacherInSubjectUpdateUseCase;
            _teacherInSubjectAddUseCase = teacherInSubjectAddUseCase;
            _teacherInSubjectGetUseCase = teacherInSubjectGetUseCase;
            _teacherInSubjectDeleteUseCase = teacherInSubjectDeleteUseCase;

            _teacherInUniversityUpdateUseCase = teacherInUniversityUpdateUseCase;
            _teacherInUniversityAddUseCase = teacherInUniversityAddUseCase;
            _teacherInUniversityGetUseCase = teacherInUniversityGetUseCase;
            _teacherInUniversityDeleteUseCase = teacherInUniversityDeleteUseCase;

            _teacherRegisterUseCase = teacherRegisterUseCase;
            _teacherConfirmEmailUseCase = teacherConfirmEmailUseCase;
            _teacherForgotPasswordUseCase = teacherForgotPasswordUseCase;
            _teacherResetPasswordUseCase = teacherResetPasswordUseCase;
        }

        [HttpPost("AddTeacher")]
        public async Task<IActionResult> AddTeacher([FromBody] TeacherAddBindingModel bindingModel)
        {
            var output = await _teacherAddUseCase.AddTeacher(_mapper.Map<TeacherAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<TeacherAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateTeacher")]
        public async Task<IActionResult> UpdateTeacher([FromBody] TeacherUpdateBindingModel bindingModel)
        {
            var output = await _teacherUpdateUseCase.UpdateTeacher(_mapper.Map<TeacherUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<TeacherUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetTeacher")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<Teacher>> GetTeacher()
        {
            return _teacherGetUseCase.GetTeacher();

        }
        [HttpGet("DeleteTeacher/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteTeacher(int Id)
        {
            var output = await _teacherDeleteUseCase.DeleteTeacher(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }
        //------------------------------------------------ teacher in proposal -------------------------------------------

        [HttpPost("AddTeacherInProposal")]
        public async Task<IActionResult> AddTeacherInProposal([FromBody] TeacherInProposalAddBindingModel bindingModel)
        {
            var output = await _teacherInProposalAddUseCase.AddTeacherInProposal(_mapper.Map<TeacherInProposalAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<TeacherInProposalAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateTeacherInProposal")]
        public async Task<IActionResult> UpdateTeacherInProposal([FromBody] TeacherInProposalUpdateBindingModel bindingModel)
        {
            var output = await _teacherInProposalUpdateUseCase.UpdateTeacherInProposal(_mapper.Map<TeacherInProposalUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<TeacherInProposalUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetTeacherInProposal")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<TeacherInProposal>> GetTeacherInProposal()
        {
            return _teacherInProposalGetUseCase.GetTeacherInProposal();

        }
        [HttpGet("DeleteTeacherInProposal/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteTeacherInProposal(int Id)
        {
            var output = await _teacherInProposalDeleteUseCase.DeleteTeacherInProposal(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }

        //------------------------------------------------- teacher in subject -------------------------------

        [HttpPost("AddTeacherInSubject")]
        public async Task<IActionResult> AddTeacherInSubject([FromBody] TeacherInSubjectAddBindingModel bindingModel)
        {
            var output = await _teacherInSubjectAddUseCase.AddTeacherInSubject(_mapper.Map<TeacherInSubjectAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<TeacherInSubjectAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateTeacherInSubject")]
        public async Task<IActionResult> UpdateTeacherInSubject([FromBody] TeacherInSubjectUpdateBindingModel bindingModel)
        {
            var output = await _teacherInSubjectUpdateUseCase.UpdateTeacherInSubject(_mapper.Map<TeacherInSubjectUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<TeacherInSubjectUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetTeacherInSubject")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<TeacherInSubject>> GetTeacherInSubject()
        {
            return _teacherInSubjectGetUseCase.GetTeacherInSubject();

        }
        [HttpGet("DeleteTeacherInSubject/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteTeacherInSubject(int Id)
        {
            var output = await _teacherInSubjectDeleteUseCase.DeleteTeacherInSubject(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }

        //----------------------------------------------- teacher in university ---------------------------------------

        [HttpPost("AddTeacherInUniversity")]
        public async Task<IActionResult> AddTeacherInUniversity([FromBody] TeacherInUniversityAddBindingModel bindingModel)
        {
            var output = await _teacherInUniversityAddUseCase.AddTeacherInUniversity(_mapper.Map<TeacherInUniversityAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<TeacherInUniversityAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateTeacherInUniversity")]
        public async Task<IActionResult> UpdateTeacherInUniversity([FromBody] TeacherInUniversityUpdateBindingModel bindingModel)
        {
            var output = await _teacherInUniversityUpdateUseCase.UpdateTeacherInUniversity(_mapper.Map<TeacherInUniversityUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<TeacherInUniversityUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetTeacherInUniversity")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<TeacherInUniversity>> GetTeacherInUniversity()
        {
            return _teacherInUniversityGetUseCase.GetTeacherInUniversity();

        }
        [HttpGet("DeleteTeacherInUniversity/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteTeacherInUniversity(int Id)
        {
            var output = await _teacherInUniversityDeleteUseCase.DeleteTeacherInUniversity(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] TeacherRegisterInputModel bindingModel)
        {
            bindingModel.IsActive = false;
            bindingModel.IsRemoved = false;
            var output = await _teacherRegisterUseCase.RegisterTeacher(bindingModel);

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<TeacherRegisterViewModel>(output.OutputModelFields));
        }
        [HttpGet("Confirmemail/{Id}/{Token}")]
        public async Task<IActionResult> Confirmemail(string Id, string Token)
        {
            var result = await _teacherConfirmEmailUseCase.ConfirmEmail(Id, Token);

            if (result.HasError)
                return BadRequest(result.Message);

            return Ok(result);
        }
        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] string Email)
        {
            var result = await _teacherForgotPasswordUseCase.ForgotPassword(Email);

            if (result.HasError)
                return BadRequest(result.Message);

            return Ok(result);
        }
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] TeacherResetPasswordBindingModel bindingModel)
        {
            var result = await _teacherResetPasswordUseCase.ResetPassword(_mapper.Map<TeacherResetPasswordInputModel>(bindingModel));

            if (result.HasError)
                return BadRequest(result.Message);

            return Ok(result);
        }
    }
}