using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Prohix.Api.Controllers.Proposals.Models;
using Prohix.Application.Services;
using Prohix.Application.Services.Proposals.ProposalInSubjects.AddUseCase;
using Prohix.Application.Services.Proposals.ProposalInSubjects.AddUseCase.Models;
using Prohix.Application.Services.Proposals.ProposalInSubjects.DeleteUseCase;
using Prohix.Application.Services.Proposals.ProposalInSubjects.GetUseCase;
using Prohix.Application.Services.Proposals.ProposalInSubjects.UpdateUseCase;
using Prohix.Application.Services.Proposals.ProposalInSubjects.UpdateUseCase.Models;
using Prohix.Application.Services.Proposals.Proposals.AddUseCase;
using Prohix.Application.Services.Proposals.Proposals.AddUseCase.Models;
using Prohix.Application.Services.Proposals.Proposals.DeleteUseCase;
using Prohix.Application.Services.Proposals.Proposals.GetUseCase;
using Prohix.Application.Services.Proposals.Proposals.UpdateUseCase;
using Prohix.Application.Services.Proposals.Proposals.UpdateUseCase.Models;
using Prohix.Application.Services.Proposals.ProposalStatuses.AddUseCase;
using Prohix.Application.Services.Proposals.ProposalStatuses.AddUseCase.Models;
using Prohix.Application.Services.Proposals.ProposalStatuses.DeleteUseCase;
using Prohix.Application.Services.Proposals.ProposalStatuses.GetUseCase;
using Prohix.Application.Services.Proposals.ProposalStatuses.UpdateUseCase;
using Prohix.Application.Services.Proposals.ProposalStatuses.UpdateUseCase.Models;
using Prohix.Core.Entities.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Proposals
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ProposalController : Controller
    {
        private readonly IMapper _mapper;

        private readonly IProposalUpdateUseCase _proposalUpdateUseCase;
        private readonly IProposalAddUseCase _proposalAddUseCase;
        private readonly IProposalGetUseCase _proposalGetUseCase;
        private readonly IProposalDeleteUseCase _proposalDeleteUseCase;
        private readonly IProposalInSubjectAddUseCase _proposalInSubjectAddUseCase;
        private readonly IProposalInSubjectUpdateUseCase _proposalInSubjectUpdateUseCase;
        private readonly IProposalInSubjectGetUseCase _proposalInSubjectGetUseCase;
        private readonly IProposalInSubjectDeleteUseCase _proposalInSubjectDeleteUseCase;
        private readonly IProposalStatusAddUseCase _proposalStatusAddUseCase;
        private readonly IProposalStatusUpdateUseCase _proposalStatusUpdateUseCase;
        private readonly IProposalStatusGetUseCase _proposalStatusGetUseCase;
        private readonly IProposalStatusDeleteUseCase _proposalStatusDeleteUseCase;

        public ProposalController(
            IMapper mapper,
            IProposalUpdateUseCase proposalUpdateUseCase,
            IProposalAddUseCase proposalAddUseCase,
            IProposalGetUseCase proposalGetUseCase,
            IProposalDeleteUseCase proposalDeleteUseCase,
            IProposalInSubjectAddUseCase proposalInSubjectAddUseCase,
            IProposalInSubjectUpdateUseCase proposalInSubjectUpdateUseCase,
            IProposalInSubjectGetUseCase proposalInSubjectGetUseCase,
            IProposalInSubjectDeleteUseCase proposalInSubjectDeleteUseCase,
            IProposalStatusAddUseCase proposalStatusAddUseCase,
            IProposalStatusUpdateUseCase proposalStatusUpdateUseCase,
            IProposalStatusGetUseCase proposalStatusGetUseCase,
            IProposalStatusDeleteUseCase proposalStatusDeleteUseCase)
        {
            _mapper = mapper;
            _proposalUpdateUseCase = proposalUpdateUseCase;
            _proposalAddUseCase = proposalAddUseCase;
            _proposalGetUseCase = proposalGetUseCase;
            _proposalDeleteUseCase = proposalDeleteUseCase;
            _proposalInSubjectAddUseCase = proposalInSubjectAddUseCase;
            _proposalInSubjectUpdateUseCase = proposalInSubjectUpdateUseCase;
            _proposalInSubjectGetUseCase = proposalInSubjectGetUseCase;
            _proposalInSubjectDeleteUseCase = proposalInSubjectDeleteUseCase;
            _proposalStatusAddUseCase = proposalStatusAddUseCase;
            _proposalStatusUpdateUseCase = proposalStatusUpdateUseCase;
            _proposalStatusGetUseCase = proposalStatusGetUseCase;
            _proposalStatusDeleteUseCase = proposalStatusDeleteUseCase;

        }

        [HttpPost("AddProposal")]
        public async Task<IActionResult> AddProposal([FromBody] ProposalAddBindingModel bindingModel)
        {
            var output = await _proposalAddUseCase.AddProposal(_mapper.Map<ProposalAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<ProposalAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateProposal")]
        public async Task<IActionResult> UpdateProposal([FromBody] ProposalUpdateBindingModel bindingModel)
        {
            var output = await _proposalUpdateUseCase.UpdateProposal(_mapper.Map<ProposalUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<ProposalUpdateViewModel>(output.OutputModelFields));
        }

       
        [HttpGet("GetProposal")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<Proposal>> GetProposal()
        {
            return _proposalGetUseCase.GetProposal();

        }
        [HttpGet("DeleteProposal/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteProposal(int Id)
        {
            var output = await _proposalDeleteUseCase.DeleteProposal(Id);
            return  Ok(_mapper.Map<DeleteOutputModel>(output));

        }

        [HttpPost("AddProposalInSubject")]
        public async Task<IActionResult> AddProposalInSubject([FromBody] ProposalInSubjectAddBindingModel bindingModel)
        {
            var output = await _proposalInSubjectAddUseCase.AddProposalInSubject(_mapper.Map<ProposalInSubjectAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<ProposalInSubjectAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateProposalInSubject")]
        public async Task<IActionResult> UpdateProposalInSubject([FromBody] ProposalInSubjectUpdateBindingModel bindingModel)
        {
            var output = await _proposalInSubjectUpdateUseCase.UpdateProposalInSubject(_mapper.Map<ProposalInSubjectUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<ProposalInSubjectUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetProposalInSubject")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<ProposalInSubject>> GetProposalInSubject()
        {
            return _proposalInSubjectGetUseCase.GetProposalInSubject();

        }

        [HttpGet("DeleteProposalInSubject/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteProposalInSubject(int Id)
        {
            var output = await _proposalInSubjectDeleteUseCase.DeleteProposalInSubject(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }

        [HttpPost("AddProposalStatus")]
        public async Task<IActionResult> AddProposalStatus([FromBody] ProposalStatusAddBindingModel bindingModel)
        {
            var output = await _proposalStatusAddUseCase.AddProposalStatus(_mapper.Map<ProposalStatusAddInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<ProposalStatusAddViewModel>(output.OutputModelFields));
        }
        [HttpPut("UpdateProposalStatus")]
        public async Task<IActionResult> UpdateProposalStatus([FromBody] ProposalStatusUpdateBindingModel bindingModel)
        {
            var output = await _proposalStatusUpdateUseCase.UpdateProposalStatus(_mapper.Map<ProposalStatusUpdateInputModel>(bindingModel));

            if (output.HasError)
                return BadRequest(output.Message);

            return Ok(_mapper.Map<ProposalStatusUpdateViewModel>(output.OutputModelFields));
        }


        [HttpGet("GetProposalStatus")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IQueryable<ProposalStatus>> GetProposalStatus()
        {
            return _proposalStatusGetUseCase.GetProposalStatus();

        }
        [HttpGet("DeleteProposalStatus/{Id}")]
        [EnableQuery(MaxExpansionDepth = 10)]
        public async Task<IActionResult> DeleteProposalStatus(int Id)
        {
            var output = await _proposalStatusDeleteUseCase.DeleteProposalStatus(Id);
            return Ok(_mapper.Map<DeleteOutputModel>(output));

        }
    }
}