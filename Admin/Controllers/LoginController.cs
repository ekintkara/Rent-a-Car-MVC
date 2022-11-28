using Business.Abstract;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AdminUI.Controllers
{
    public class LoginController : Controller
    {
        IUserService userService;
        AContext c = new AContext();

        public LoginController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult LoginPanel(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> LoginPanel(User user)
        {
            var informations = c.users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if (informations != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, informations.UserName),
                    new Claim(ClaimTypes.Role,informations.UserRole)
                };
                var identity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal claimprincipal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(claimprincipal);

                if (TempData["returnUrl"] != null)
                {
                    if (Url.IsLocalUrl(TempData["returnUrl"].ToString()))
                    {
                        return Redirect(TempData["returnUrl"].ToString());
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User u)
        {
            userService.add(u);
            return RedirectToAction("LoginPanel");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
