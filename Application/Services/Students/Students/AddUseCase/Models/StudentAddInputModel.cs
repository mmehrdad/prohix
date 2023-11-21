using Prohix.Core.Constants.Commons;
using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Students.AddUseCase.Models
{
    public class StudentAddInputModel
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long? CitizenshipId { get; set; }
        public long? SecondCitizenshipId { get; set; }
        public virtual Gender? Gender { get; set; }
        public string? PostalCode { get; set; }
        public string? Address { get; set; }
        public long? MotherTongueId { get; set; }
        
    }
}