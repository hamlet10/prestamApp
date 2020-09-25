using Microsoft.AspNetCore.Identity;
using System;

namespace PrestamApp.Auth.Data
{
    public class ApplicationUser : IdentityUser<int>
    {
        public int? EnterpriseId { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

