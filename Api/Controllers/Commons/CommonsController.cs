using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

using Prohix.Application.Services;
using Prohix.Application.Services.Commons.Countries.AddUseCase;
using Prohix.Application.Services.Commons.Countries.AddUseCase.Models;
using Prohix.Application.Services.Commons.Countries.DeleteUseCase;
using Prohix.Application.Services.Commons.Countries.GetUseCase;
using Prohix.Application.Services.Commons.Countries.UpdateUseCase;
using Prohix.Application.Services.Commons.Countries.UpdateUseCase.Models;
using Prohix.Application.Services.Commons.FieldOfStudies.AddUseCase;
using Prohix.Application.Services.Commons.FieldOfStudies.AddUseCase.Models;
using Prohix.Application.Services.Commons.FieldOfStudies.DeleteUseCase;
using Prohix.Application.Services.Commons.FieldOfStudies.GetUseCase;
using Prohix.Application.Services.Commons.FieldOfStudies.UpdateUseCase;
using Prohix.Application.Services.Commons.FieldOfStudies.UpdateUseCase.Models;
using Prohix.Application.Services.Commons.GradeOfStudies.AddUseCase;
using Prohix.Application.Services.Commons.GradeOfStudies.AddUseCase.Models;
using Prohix.Application.Services.Commons.GradeOfStudies.DeleteUseCase;
using Prohix.Application.Services.Commons.GradeOfStudies.GetUseCase;
using Prohix.Application.Services.Commons.GradeOfStudies.UpdateUseCase;
using Prohix.Application.Services.Commons.GradeOfStudies.UpdateUseCase.Models;
using Prohix.Application.Services.Commons.Languages.AddUseCase;
using Prohix.Application.Services.Commons.Languages.AddUseCase.Models;
using Prohix.Application.Services.Commons.Languages.DeleteUseCase;
using Prohix.Application.Services.Commons.Languages.GetUseCase;
using Prohix.Application.Services.Commons.Languages.UpdateUseCase;
using Prohix.Application.Services.Commons.Languages.UpdateUseCase.Models;
using Prohix.Application.Services.Commons.Publics.EmailService;
using Prohix.Application.Services.Commons.Publics.EmailService.Models;
using Prohix.Application.Services.Commons.Universities.AddUseCase;
using Prohix.Application.Services.Commons.Universities.AddUseCase.Models;
using Prohix.Application.Services.Commons.Universities.DeleteUseCase;
using Prohix.Application.Services.Commons.Universities.GetUseCase;
using Prohix.Application.Services.Commons.Universities.UpdateUseCase;
using Prohix.Application.Services.Commons.Universities.UpdateUseCase.Models;
using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Commons.Models
{
    [Route("api/[controller]")]
    //[Authorize]
    [ApiController]
    public class CommonController : Controller
    {
        private readonly IMapper _mapper;

        private readonly IGradeOfStudyUpdateUseCase _gradeOfStudyUpdateUseCase;
        private readonly IGradeOfStudyAddUseCase _gradeOfStudyAddUseCase;
        private readonly IGradeOfStudyGetUseCase _gradeOfStudyGetUseCase;
        private readonly IGradeOfStudyDeleteUseCase _gradeOfStudyDeleteUseCase;

        private readonly IFieldOfStudyUpdateUseCase _fieldOfStudyUpdateUseCase;
        private readonly IFieldOfStudyAddUseCase _fieldOfStudyAddUseCase;
        private readonly IFieldOfStudyGetUseCase _fieldOfStudyGetUseCase;
        private readonly IFieldOfStudyDeleteUseCase _fieldOfStudyDeleteUseCase;

        private readonly IUniversityUpdateUseCase _universityUpdateUseCase;
        private readonly IUniversityAddUseCase _universityAddUseCase;
        private readonly IUniversityGetUseCase _universityGetUseCase;
        private readonly IUniversityDeleteUseCase _universityDeleteUseCase;

        private readonly ICountryUpdateUseCase _countryUpdateUseCase;
        private readonly ICountryAddUseCase _countryAddUseCase;
        private readonly ICountryGetUseCase _countryGetUseCase;
        private readonly ICountryDeleteUseCase _countryDeleteUseCase;

        private readonly ILanguageUpdateUseCase _languageUpdateUseCase;
        private readonly ILanguageAddUseCase _languageAddUseCase;
        private readonly ILanguageGetUseCase _languageGetUseCase;
        private readonly ILanguageDeleteUseCase _languageDeleteUseCase;

        private readonly IEmailService _emailService;

        public CommonController(
            IMapper mapper,
            IGradeOfStudyUpdateUseCase gradeOfStudyUpdateUseCase,
            IGradeOfStudyAddUseCase gradeOfStudyAddUseCase,
            IGradeOfStudyGetUseCase gradeOfStudyGetUseCase,
            IGradeOfStudyDeleteUseCase gradeOfStudyDeleteUseCase,

            IFieldOfStudyUpdateUseCase fieldOfStudyUpdateUseCase,
            IFieldOfStudyAddUseCase fieldOfStudyAddUseCase,
            IFieldOfStudyGetUseCase fieldOfStudyGetUseCase,
            IFieldOfStudyDeleteUseCase fieldOfStudyDeleteUseCase,

            IUniversityUpdateUseCase universityUpdateUseCase,
            IUniversityAddUseCase universityAddUseCase,
            IUniversityGetUseCase universityGetUseCase,
            IUniversityDeleteUseCase universityDeleteUseCase,

            ICountryUpdateUseCase countryUpdateUseCase,
            ICountryAddUseCase countryAddUseCase,
            ICountryGetUseCase countryGetUseCase,
            ICountryDeleteUseCase countryDeleteUseCase,

            ILanguageUpdateUseCase languageUpdateUseCase,
            ILanguageAddUseCase languageAddUseCase,
            ILanguageGetUseCase languageGetUseCase,
            ILanguageDeleteUseCase languageDeleteUseCase,

            IEmailService emailService

            )
        {
            _mapper = mapper;
            _gradeOfStudyUpdateUseCase = gradeOfStudyUpdateUseCase;
            _gradeOfStudyAddUseCase = gradeOfStudyAddUseCase;
            _gradeOfStudyGetUseCase = gradeOfStudyGetUseCase;
            _gradeOfStudyDeleteUseCase = gradeOfStudyDeleteUseCase;

            _fieldOfStudyUpdateUseCase = fieldOfStudyUpdateUseCase;
            _fieldOfStudyAddUseCase = fieldOfStudyAddUseCase;
            _fieldOfStudyGetUseCase = fieldOfStudyGetUseCase;
            _fieldOfStudyDeleteUseCase = fieldOfStudyDeleteUseCase;

            _universityUpdateUseCase = universityUpdateUseCase;
            _universityAddUseCase = universityAddUseCase;
            _universityGetUseCase = universityGetUseCase;
            _universityDeleteUseCase = universityDeleteUseCase;

            _countryUpdateUseCase = countryUpdateUseCase;
            _countryAddUseCase = countryAddUseCase;
            _countryGetUseCase = countryGetUseCase;
            _countryDeleteUseCase = countryDeleteUseCase;

            _languageUpdateUseCase = languageUpdateUseCase;
            _languageAddUseCase = languageAddUseCase;
            _languageGetUseCase = languageGetUseCase;
            _languageDeleteUseCase = languageDeleteUseCase;

            _emailService=emailService;


        }

        [HttpPost("AddGradeOfStudy")]
        public async Task<IActionResult> AddGradeOfStudy([FromBody] GradeOfStudyAddBindingModel bindingModel)
        {
            var output = await _gradeOfStudyAddUseCase.AddGradeOfStudy(_mapper.Map<GradeOfStudyAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<GradeOfStudyAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateGradeOfStudy")]
        public async Task<IActionResult> UpdateGradeOfStudy([FromBody] GradeOfStudyUpdateBindingModel bindingModel)
        {
            var output = await _gradeOfStudyUpdateUseCase.UpdateGradeOfStudy(_mapper.Map<GradeOfStudyUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<GradeOfStudyUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetGradeOfStudy")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<GradeOfStudy>> GetGradeOfStudy()
        {
            return _gradeOfStudyGetUseCase.GetGradeOfStudy();

        }
        [HttpGet("DeleteGradeOfStudy/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteGradeOfStudy(int Id)
        {
            var output = await _gradeOfStudyDeleteUseCase.DeleteGradeOfStudy(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }
        //------------------------------------ fieldOfStudy --------------------------------------
        [HttpPost("AddFieldOfStudy")]
        public async Task<IActionResult> AddFieldOfStudy([FromBody] FieldOfStudyAddBindingModel bindingModel)
        {
            var output = await _fieldOfStudyAddUseCase.AddFieldOfStudy(_mapper.Map<FieldOfStudyAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<FieldOfStudyAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateFieldOfStudy")]
        public async Task<IActionResult> UpdateFieldOfStudy([FromBody] FieldOfStudyUpdateBindingModel bindingModel)
        {
            var output = await _fieldOfStudyUpdateUseCase.UpdateFieldOfStudy(_mapper.Map<FieldOfStudyUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<FieldOfStudyUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetFieldOfStudy")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<FieldOfStudy>> GetFieldOfStudy()
        {
            return await _fieldOfStudyGetUseCase.GetFieldOfStudy();

        }
        [HttpGet("DeleteFieldOfStudy/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteFieldOfStudy(int Id)
        {
            var output = await _fieldOfStudyDeleteUseCase.DeleteFieldOfStudy(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }

        //---------------------------------------------------- university --------------------------

        [HttpPost("AddUniversity")]
        public async Task<IActionResult> AddUniversity([FromBody] UniversityAddBindingModel bindingModel)
        {
            var output = await _universityAddUseCase.AddUniversity(_mapper.Map<UniversityAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<UniversityAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateUniversity")]
        public async Task<IActionResult> UpdateUniversity([FromBody] UniversityUpdateBindingModel bindingModel)
        {
            var output = await _universityUpdateUseCase.UpdateUniversity(_mapper.Map<UniversityUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<UniversityUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetUniversity/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<University>> GetUniversity(long Id)
        {
            return await _universityGetUseCase.GetUniversity(Id);

        }
        [HttpGet("DeleteUniversity/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteUniversity(int Id)
        {
            var output = await _universityDeleteUseCase.DeleteUniversity(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }

        //------------------------------------------------ country ---------------------------------------

        [HttpPost("AddCountry")]
        public async Task<IActionResult> AddCountry([FromBody] CountryAddBindingModel bindingModel)
        {
            var output = await _countryAddUseCase.AddCountry(_mapper.Map<CountryAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<CountryAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateCountry")]
        public async Task<IActionResult> UpdateCountry([FromBody] CountryUpdateBindingModel bindingModel)
        {
            var output = await _countryUpdateUseCase.UpdateCountry(_mapper.Map<CountryUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<CountryUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetCountry")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<Country>> GetCountry()
        {
            return await _countryGetUseCase.GetCountry();

        }
        [HttpGet("DeleteCountry/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteCountry(int Id)
        {
            var output = await _countryDeleteUseCase.DeleteCountry(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }
        //------------------------------------------------ language ---------------------------------------
        [HttpPost("AddLanguage")]
        public async Task<IActionResult> AddLanguage([FromBody] LanguageAddBindingModel bindingModel)
        {
            var output = await _languageAddUseCase.AddLanguage(_mapper.Map<LanguageAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<LanguageAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateLanguage")]
        public async Task<IActionResult> UpdateLanguage([FromBody] LanguageUpdateBindingModel bindingModel)
        {
            var output = await _languageUpdateUseCase.UpdateLanguage(_mapper.Map<LanguageUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<LanguageUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetLanguage")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<Language>> GetLanguage()
        {
            return await _languageGetUseCase.GetLanguage();

        }
        [HttpGet("DeleteLanguage/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteLanguage(int Id)
        {
            var output = await _languageDeleteUseCase.DeleteLanguage(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }

        
        [HttpPost("SendEmail")]
        public async Task<IActionResult> SendEmail(EmailServiceInputModel inputModel)
        {
            var output = await _emailService.SendEmail(inputModel);
            return Ok();

        }
    }
}    