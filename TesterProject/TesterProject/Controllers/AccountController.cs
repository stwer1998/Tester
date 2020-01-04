using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using TesterCore.Dto;
using TesterCore.Interfaces;
using TesterCore.Model;

namespace TesterProject.Controllers
{
    public class AccountController : Controller
    {
        private IUserRepository db;
        public AccountController(IUserRepository db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(DtoUser model)
        {
            var user = db.GetUser(model.Login, model.Password);
            if (user == null)
            {
                ModelState.AddModelError("", "Пользователь с таким логином и паролем не найден");
            }
            if (ModelState.IsValid)
            {
                await Authenticate(user.Login); // аутентификация

                return RedirectToAction("Index", "Home");
            }
            else return View(model);

        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(DtoRegister model)
        {
            if (!db.CheckLogin(model.Login))
            {
                ModelState.AddModelError("Login", "Пользователь с таким логином уже есть");
            }
            if (ModelState.IsValid)
            {
                User u = new User(model);
                db.AddUser(u);
                await Authenticate(u.Name);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}