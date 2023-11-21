using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Jobs.AddUseCase.Models
{
    public class JobAddInputModel : BaseEntity<long>
    {
        public string JobTitle { get; set; }
        public string Employer { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Institute { get; set; }
        public Guid StudentId { get; set; }
    }
}