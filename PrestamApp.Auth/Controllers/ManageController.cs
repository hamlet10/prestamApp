using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PrestamApp.Auth.Data;
using PrestamApp.Auth.Models;

namespace PrestamApp.Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageController : ControllerBase
    {
          private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public ManageController(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            SignInManager<ApplicationUser> signInManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
    
        [HttpPost]
        [Route("[action]")]
        public async Task<IdentityResult> CreateAsync([FromBody] UserInputModel input)
        {
            var user = new ApplicationUser
            {
                Email = input.Email,
                UserName = input.UserName,
                FirstName = input.FirstName,
                LastName = input.LastName,
                EnterpriseId = input.EnterpriseId,
                CreatedBy = input.CreatedBy,
                IsActive = true
            };

            var result = await _userManager.CreateAsync(user, input.Password);

            if (result.Succeeded)
            {
               
                    var currentRole = await _roleManager.FindByIdAsync(input.RoleId.ToString());
                    if (currentRole != null)
                    {
                        await _userManager.AddToRoleAsync(user, currentRole.Name);
                    }
               
                return result;
            }
            else
            {
                string errors = string.Empty;
                string codes = string.Empty;
                foreach (var item in result.Errors)
                {
                    codes += $"Code: {item.Code}\n";
                    errors += $"Description: {item.Description}\n";
                }
                return IdentityResult.Failed(new IdentityError { Code = codes, Description = errors });
            }
        }
    }
}