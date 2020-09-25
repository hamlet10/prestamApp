namespace PrestamApp.Auth.Models
{
    public class UserInputModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
        public int? EnterpriseId { get; set; }
        public string CreatedBy { get; set; }
    }
}
