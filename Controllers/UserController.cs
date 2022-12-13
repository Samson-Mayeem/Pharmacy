using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using samPharma.Data;
using samPharma.Models;
using samPharma.ViewModel;
using System.Security.Claims;
using static IdentityServer4.Models.IdentityResources;

namespace samPharma.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly samDbContext _context;
        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, samDbContext samDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = samDbContext;
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel loginviewmodel)
        {
            var user = await _userManager.FindByEmailAsync(loginviewmodel.Email);

            if (!ModelState.IsValid) 
           {
                var claims = new List<Claim>();

                claims.Add(new Claim("Email", loginviewmodel.Email));
                claims.Add(new Claim(ClaimTypes.Email, loginviewmodel.Email));
                var claimsIdebtity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                //var claimsprincipal = new ClaimsPrincipal(claimsprincipal);
                return View(loginviewmodel);
           }

            /*if(user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginviewmodel.Password); 
                return View(loginviewmodel);
            }*/
            return BadRequest();
           
        }
    }
}
