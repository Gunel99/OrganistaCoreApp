using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrganistaProject.Models;

namespace OrganistaProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);
            AppUser appUser = new AppUser
            {
                Fullname = registerVM.Fullname,
                UserName = registerVM.Username,
                Email = registerVM.Email
            };

            IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerVM.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerVM);
            }

            //await _userManager.AddToRoleAsync(appUser, Helpers.Helper.Roles.Admin.ToString());
            await _signInManager.SignInAsync(appUser, true);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View(login);

            AppUser loginUser = await _userManager.FindByEmailAsync(login.Email);

            if (loginUser == null)
            {
                ModelState.AddModelError("", "Email ve ya password dogru deyil!");
                return View(login);
            }

            var signInResult = await _signInManager.PasswordSignInAsync(loginUser, login.Password, false, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email ve ya password dogru deyil!");
                return View(login);
            }

            return RedirectToAction("Index", "Home");

        }

        public async Task CreateRole()
        {
            if (!(await _roleManager.RoleExistsAsync(Helpers.Helper.Roles.Admin.ToString())))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Roles.Admin.ToString()));
            }

            if (!(await _roleManager.RoleExistsAsync(Helpers.Helper.Roles.Member.ToString())))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Roles.Member.ToString()));
            }
        }
    
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}