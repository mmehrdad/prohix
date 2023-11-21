namespace Prohix.Api.Controllers.Students.Models
{
    public class StudentRegisterBindingModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public bool IsRemoved { get; set; } = false;
        public bool IsActive { get; set; } = false;
    }
}
