using AspNetCoreHero.ToastNotification.Abstractions;
using BTLASPMONGO.Models.BusinessModels;
using BTLASPMONGO.Util;
using BTLASPMONGO.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BTLASPMONGO.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    public class AccountController : Controller
    {
        IRepositoryAccount repositoryAccount;
        private readonly INotyfService _notyf;

        public AccountController(IRepositoryAccount repositoryAccount, INotyfService notyf)
        {
            this._notyf = notyf;
            this.repositoryAccount = repositoryAccount;
        }
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        // login authentication
        [Route("authentication")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Authentication(LoginViewModel authen)
        {
            if (!ModelState.IsValid)
            {
                return View("Login");
            }
            var md5pass = Utility.MD5Hash(authen.Password);
            var account = repositoryAccount.Account_Check(authen.Username, md5pass);
            if (account != null && account.status == 1)
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name ,account.username),
                    new Claim(ClaimTypes.NameIdentifier ,account.fullname),
                    new Claim(ClaimTypes.Role,account.role),
                    new Claim("Avatar",account.avatar),
                    new Claim("AccountId",account._id)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,
                        new AuthenticationProperties
                        {
                            IsPersistent = true
                        });
                return Redirect("/admin");
            }else{
                TempData["uername"] = authen.Username;
                TempData["password"] = authen.Password;
                TempData["error"] = "Email or Password Incorrect";
                return Redirect("/admin/login");
            }
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login));
        }
    }
}
