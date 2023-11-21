using Prohix.Application.Services.Commons.Countries.DeleteUseCase;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.GradeOfStudies.DeleteUseCase
{
    public class GradeOfStudyDeleteUseCase : IGradeOfStudyDeleteUseCase
    {
        private readonly IGradeOfStudyRepository _gradeOfStudyRepository;

        public GradeOfStudyDeleteUseCase(IGradeOfStudyRepository gradeOfStudyRepository)
        {
            _gradeOfStudyRepository = gradeOfStudyRepository;
        }

        public async Task<DeleteOutputModel> DeleteGradeOfStudy(int id)
        {
            var foundEntity = await _gradeOfStudyRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _gradeOfStudyRepository.RemoveAsync(foundEntity);
            var result = await _gradeOfStudyRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "Grade of study deleted sucessfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}