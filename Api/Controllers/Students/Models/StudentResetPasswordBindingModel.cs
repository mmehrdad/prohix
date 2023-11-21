namespace Prohix.Api.Controllers.Students.Models
{
    public class StudentResetPasswordBindingModel
    {
        public string Token { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
    }
}
