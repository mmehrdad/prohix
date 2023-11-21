using Prohix.Core.Entities.Subjects;
using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInSubjects.AddUseCase.Models
{
    public class TeacherInSubjectAddInputModel
    {
        public long SubjectId { get; set; }
        public Guid TeacherId { get; set; }
    }
}