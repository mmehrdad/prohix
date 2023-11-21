using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Proposals.Proposals.DeleteUseCase
{
    public interface IProposalDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteProposal(int Id); 
    }
}