using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInUniversities.AddUseCase.Models
{
    public class TeacherInUniversityAddOutputModelFields
    {
        public long Id { get; set; }
        public long UniversityId { get; set; }
        public Guid TeacherId { get; set; }
    }
}