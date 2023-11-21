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
using Prohix.Application.Services.Commons.GradeOfStudies.AddUseCase.Models;

namespace Prohix.Application.Services.Commons.GradeOfStudies.AddUseCase
{
    public class GradeOfStudyAddUseCase : IGradeOfStudyAddUseCase
    {
        private readonly IMapper _mapper;
        private readonly IGradeOfStudyRepository _gradeOfStudyRepository;

        public GradeOfStudyAddUseCase(

            IGradeOfStudyRepository gradeOfStudyRepository,
            IMapper mapper)
        {
            _gradeOfStudyRepository = gradeOfStudyRepository;
            _mapper = mapper;
        }

        public async Task<GradeOfStudyAddOutputModel> AddGradeOfStudy(GradeOfStudyAddInputModel inputModel)
        {
            var newGradeOfStudy = _mapper.Map<GradeOfStudy>(inputModel);

            await _gradeOfStudyRepository.AddAsync(newGradeOfStudy);

            var result = _gradeOfStudyRepository.SaveChanges();
            if (result > 0)
                return new GradeOfStudyAddOutputModel
                {
                    HasError = false,
                    OutputModelFields = _mapper.Map<GradeOfStudyAddOutputModelFields>(newGradeOfStudy)
                };

            return new GradeOfStudyAddOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}