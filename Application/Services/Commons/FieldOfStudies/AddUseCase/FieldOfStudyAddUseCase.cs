using Prohix.Application.Services.Commons.Countries.AddUseCase.Models;
using Prohix.Application.Services.Commons.Countries.AddUseCase;
using Prohix.Application.Services.Helper;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prohix.Application.Services.Commons.FieldOfStudies.AddUseCase.Models;

namespace Prohix.Application.Services.Commons.FieldOfStudies.AddUseCase
{
    public class FieldOfStudyAddUseCase : IFieldOfStudyAddUseCase
    {
        private readonly IMapper _mapper;
        private readonly IFieldOfStudyRepository _fieldOfStudyRepository;

        public FieldOfStudyAddUseCase(

            IFieldOfStudyRepository fieldOfStudyRepository,
            IMapper mapper)
        {
            _fieldOfStudyRepository = fieldOfStudyRepository;
            _mapper = mapper;
        }

        public async Task<FieldOfStudyAddOutputModel> AddFieldOfStudy(FieldOfStudyAddInputModel inputModel)
        {
            var newFieldOfStudy = _mapper.Map<FieldOfStudy>(inputModel);

            await _fieldOfStudyRepository.AddAsync(newFieldOfStudy);

            var result = _fieldOfStudyRepository.SaveChanges();
            if (result > 0)
                return new FieldOfStudyAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<FieldOfStudyAddOutputModelFields>(newFieldOfStudy)
                };

            return new FieldOfStudyAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}