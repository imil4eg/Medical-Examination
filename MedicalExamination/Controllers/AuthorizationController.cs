using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalExamination.BLL;
using MedicalExamination.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MedicalExamination.Controllers
{
    [Produces("application/json")]
    [Route("/api/[controller]")]
    [ApiController]
    public sealed class AuthorizationController : ControllerBase
    {
        private IUserService _userService;

        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthorizationController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        //[Route("~/api/login")]
        [HttpPost]
        public async Task<ActionResult> Login([FromBody] LoginModel model)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(model.UserName);

            if (user == null)
            {
                return Ok(new {success = false});
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
            return Ok(result.Succeeded ?  new {success = true, error = string.Empty } : new {success = false, error = "Неверный логин или пароль."});
        }
    }
}
