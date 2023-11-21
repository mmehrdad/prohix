using Prohix.Core.Constants.Commons;
using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Teachers.AddUseCase.Models
{
    public class TeacherAddInputModel
    {
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public virtual Gender? Gender { get; set; }
        
    }
}