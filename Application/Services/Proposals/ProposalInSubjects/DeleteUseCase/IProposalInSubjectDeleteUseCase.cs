using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.ProposalInSubjects.DeleteUseCase
{
    public interface IProposalInSubjectDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteProposalInSubject(int Id); 
    }
}