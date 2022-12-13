using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using samPharma.Data;
using samPharma.Models;
using samPharma.ViewModel;

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
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginviewmodel)
        {
           if(!ModelState.IsValid) 
           {
              return View(loginviewmodel);
              var user = await _userManager.FindByEmailAsync(loginviewmodel.Email);
           }
                     if(user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginviewmodel.Password);            }
        }
    }
}
