using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Teachers.TeacherInProposals.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Teachers.TeacherInProposals.AddUseCase
{
    public interface ITeacherInProposalAddUseCase : IScopedDependency
    {
      Task<TeacherInProposalAddOutputModel> AddTeacherInProposal(TeacherInProposalAddInputModel inputModel);  
    }
}