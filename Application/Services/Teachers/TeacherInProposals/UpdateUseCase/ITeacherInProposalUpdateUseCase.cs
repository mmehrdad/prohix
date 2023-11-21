using Prohix.Application.Services.Teachers.TeacherInProposals.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInProposals.UpdateUseCase
{
    public interface ITeacherInProposalUpdateUseCase: IScopedDependency
    {
      Task<TeacherInProposalUpdateOutputModel> UpdateTeacherInProposal(TeacherInProposalUpdateInputModel inputModel);  
    }
}