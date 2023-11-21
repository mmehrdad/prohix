using Prohix.Application.Services.Commons.Countries.UpdateUseCase.Models;
using Prohix.Application.Services.Commons.Countries.UpdateUseCase;
using Prohix.Application.Services.Helper;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prohix.Application.Services.Commons.FieldOfStudies.UpdateUseCase.Models;

namespace Prohix.Application.Services.Commons.FieldOfStudies.UpdateUseCase
{
    public class FieldOfStudyUpdateUseCase : IFieldOfStudyUpdateUseCase
    {
        private readonly IMapper _mapper;
        private readonly IFieldOfStudyRepository _fieldOfStudyRepository;

        public FieldOfStudyUpdateUseCase(

            IFieldOfStudyRepository fieldOfStudyRepository,
            IMapper mapper)
        {
            _fieldOfStudyRepository = fieldOfStudyRepository;
            _mapper = mapper;
        }
        public async Task<FieldOfStudyUpdateOutputModel> UpdateFieldOfStudy(FieldOfStudyUpdateInputModel inputModel)
        {
            var fieldOfStudyEntity = await _fieldOfStudyRepository.FindAsync(inputModel.Id);
            if (fieldOfStudyEntity == null)
                return new FieldOfStudyUpdateOutputModel { HasError = true, Message = "Field of study not found !!" };

            var fieldOfStudyUpForUpdate = _mapper.Map<FieldOfStudyUpdateInputModel, FieldOfStudy>(inputModel, fieldOfStudyEntity);

            await _fieldOfStudyRepository.UpdateAsync(fieldOfStudyUpForUpdate);

            var result = await _fieldOfStudyRepository.SaveChangesAsync();

            return result > 0 ? new FieldOfStudyUpdateOutputModel { OutputModelFields = _mapper.Map<FieldOfStudyUpdateOutputModelFields>(fieldOfStudyUpForUpdate) } :
                                new FieldOfStudyUpdateOutputModel { HasError = true, Message = "Somthing went wrong !!" };

        }
    }
}