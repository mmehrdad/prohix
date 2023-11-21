using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Students.Jobs.AddUseCase.Models;
using Prohix.Application.Services.Students.Jobs.AddUseCase;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Prohix.Application.Services.Students.Jobs.AddUseCase
{
    public class JobAddUseCase : IJobAddUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly IJobRepository _jobRepository;

        public JobAddUseCase(

            IUserInformationProvider userInformationProvider,
            IJobRepository jobRepository,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<JobAddOutputModel> AddJob(JobAddInputModel inputModel)
        {
            var newJob = _mapper.Map<Job>(inputModel);

            inputModel.CreatedTime = DateTime.Now.Date;
            inputModel.StudentId = userInformationProvider.CurrentUserId;

            await _jobRepository.AddAsync(newJob);

            var result = _jobRepository.SaveChanges();
            if (result > 0)
                return new JobAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<JobAddOutputModelFields>(newJob)
                };

            return new JobAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}