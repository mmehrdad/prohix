using Prohix.Core.Entities.Students;
using Prohix.Core.Entities.Teachers;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.RepositoryInterfaces.Teachers
{
    public interface ITeacherInProposalRepository : IBaseRepository<TeacherInProposal>, IScopedDependency
    {
    }
}
