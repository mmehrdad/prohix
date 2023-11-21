namespace Prohix.Api.Controllers.Students.Models
{
    public class StudentLoginViewModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public string UserName { get; set; }
    }
}
