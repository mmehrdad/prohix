namespace Prohix.Api.Controllers.Teachers.Models
{
    public class TeacherResetPasswordBindingModel
    {
        public string Token { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
    }
}
