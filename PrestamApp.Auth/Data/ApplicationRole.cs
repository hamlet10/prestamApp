using Microsoft.AspNetCore.Identity;

namespace PrestamApp.Auth.Data
{
    public class ApplicationRole : IdentityRole<int>
    {
        public string Description { get; set; }
    }
}
