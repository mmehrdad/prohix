using Prohix.Core.Constants.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Teachers.UpdateUseCase.Models
{
    public class TeacherUpdateInputModel
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public virtual Gender? Gender { get; set; }
    }
}