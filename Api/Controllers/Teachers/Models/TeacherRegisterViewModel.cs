namespace Prohix.Api.Controllers.Teachers.Models
{
    public class TeacherRegisterViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public bool IsRemoved { get; set; } = false;
        public bool IsActive { get; set; } = false;
    }
}
