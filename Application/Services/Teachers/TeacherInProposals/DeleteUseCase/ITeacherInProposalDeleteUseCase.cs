using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInProposals.DeleteUseCase
{
    public interface ITeacherInProposalDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteTeacherInProposal(int Id); 
    }
}