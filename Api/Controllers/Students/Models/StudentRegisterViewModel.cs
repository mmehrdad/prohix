namespace Prohix.Api.Controllers.Students.Models
{
    public class StudentRegisterViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public bool IsRemoved { get; set; } = false;
        public bool IsActive { get; set; } = false;
        public bool HasError { get; set; }
        public string Message { get; set; }
    }
}
