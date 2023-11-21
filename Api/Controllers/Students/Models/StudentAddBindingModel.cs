using Prohix.Core.Constants.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Students.Models
{
    public class StudentAddBindingModel
    {
        public Guid Id { get; set; }
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
        public string? Code { get; set; }
        public bool? IsActive { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedTime { get; set; } = DateTime.Now;
        public DateTime? ModifiedDateTime { get; set; }
        public bool? IsRemoved { get; set; } = false;
        public DateTime? RemovedDateTime { get; set; }
    }
}