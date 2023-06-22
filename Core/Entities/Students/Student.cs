using Microsoft.AspNetCore.Identity;
using Prohix.Core.Constants.Commons;
using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Proposals;
using Studex.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Students
{
    public class Student : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SureName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual Country Citizenship { get; set; }
        public long CitizenshipId { get; set; }
        public virtual Country SecoundCitizenship { get; set; }
        public long SecoundCitizenshipId { get; set; }
        public virtual Gender Gender { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public  Language MotherTongue { get; set; }
        public long MotherTongueID { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Proposal> Proposals { get; set; }
        public virtual ICollection<StudentInLanguage> StudentInLanguages { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? ModifiedDateTime { get; set; }
        public bool IsRemoved { get; set; } = false;
        public DateTime? RemovedDateTime { get; set; }
    }
}
