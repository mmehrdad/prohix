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
using Prohix.Application.Services.Commons.GradeOfStudies.UpdateUseCase.Models;

namespace Prohix.Application.Services.Commons.GradeOfStudies.UpdateUseCase
{
    public class GradeOfStudyUpdateUseCase : IGradeOfStudyUpdateUseCase
    {
        private readonly IMapper _mapper;
        private readonly IGradeOfStudyRepository _gradeOfStudyRepository;

        public GradeOfStudyUpdateUseCase(

            IGradeOfStudyRepository gradeOfStudyRepository,
            IMapper mapper)
        {
            _gradeOfStudyRepository = gradeOfStudyRepository;
            _mapper = mapper;
        }
        public async Task<GradeOfStudyUpdateOutputModel> UpdateGradeOfStudy(GradeOfStudyUpdateInputModel inputModel)
        {
            var gradeOfStudyEntity = await _gradeOfStudyRepository.FindAsync(inputModel.Id);
            if (gradeOfStudyEntity == null)
                return new GradeOfStudyUpdateOutputModel { HasError = true, Message = "Grade of study not found !!" };

            var gradeOfStudyUpForUpdate = _mapper.Map<GradeOfStudyUpdateInputModel, GradeOfStudy>(inputModel, gradeOfStudyEntity);

            await _gradeOfStudyRepository.UpdateAsync(gradeOfStudyUpForUpdate);

            var result = await _gradeOfStudyRepository.SaveChangesAsync();

            return result > 0 ? new GradeOfStudyUpdateOutputModel { OutputModelFields = _mapper.Map<GradeOfStudyUpdateOutputModelFields>(gradeOfStudyUpForUpdate) } :
                                new GradeOfStudyUpdateOutputModel { HasError = true, Message = "Somthing went wrong !!" };

        }
    }
}