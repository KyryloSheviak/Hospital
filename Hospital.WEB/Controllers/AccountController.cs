using System.Threading.Tasks;
using Hospital.DAL.Entities;
using Hospital.WEB.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.WEB.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Route("register")]
        [HttpGet]
        public ActionResult Register() => View();

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = model.Email,
                    UserName = model.Email
                };
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [Route("logout")]
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Route("login")]
        public ActionResult Login()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel loginModel)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(loginModel.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "User doesn't found");
            }
            else
            {
                await _signInManager.SignOutAsync();
                await _signInManager.SignInAsync(user, new AuthenticationProperties
                {
                    IsPersistent = true
                });
                return RedirectToAction("Index", "Home");
            }
            return View(loginModel);
        }

        public IActionResult Settings()
        {
            return View();
        }
    }
}