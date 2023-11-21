using AutoMapper;
using Prohix.Application.Services.Helper;
using Prohix.Application.Services.Students.Educations.AddUseCase.Models;
using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Educations.AddUseCase
{
    public class EducationAddUseCase : IEducationAddUseCase
    {
        private readonly IUserInformationProvider userInformationProvider;
        private readonly IMapper _mapper;
        private readonly IEducationRepository _educationRepository;

        public EducationAddUseCase(

            IUserInformationProvider userInformationProvider,
            IEducationRepository educationRepository,
            IMapper mapper)
        {
            this.userInformationProvider = userInformationProvider;
            _educationRepository = educationRepository;
            _mapper = mapper;
        }

        public async Task<EducationAddOutputModel> AddEducation(EducationAddInputModel inputModel)
        {
            var newEducation = _mapper.Map<Education>(inputModel);

            inputModel.CreatedTime = DateTime.Now.Date;
            inputModel.StudentId = userInformationProvider.CurrentUserId;

            await _educationRepository.AddAsync(newEducation);

            var result = _educationRepository.SaveChanges();
            if (result > 0)
                return new EducationAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<EducationAddOutputModelFields>(newEducation)
                };

            return new EducationAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}