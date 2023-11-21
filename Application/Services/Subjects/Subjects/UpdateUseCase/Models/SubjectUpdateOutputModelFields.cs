using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Subjects.Subjects.UpdateUseCase.Models
{
    public class SubjectUpdateOutputModelFields
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}