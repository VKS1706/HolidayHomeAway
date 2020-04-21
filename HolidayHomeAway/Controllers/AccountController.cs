using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Auth;
using HolidayHomeAway.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HolidayHomeAway.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl) //Runs this
        {
            return View(new LoginViewModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel) //Straight to this
        {
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }

            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);

            if (user != null)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);

                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                    {
                        return RedirectToAction("Index", "Home"); //needs to be checked - may not be home controller
                    }

                    return Redirect(loginViewModel.ReturnUrl);
                }
            }

            ModelState.AddModelError("", "Username/password not found");
            return View(loginViewModel);
        }

        [AllowAnonymous]
        public IActionResult Register() //Runs this 
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel) //Method that is Not running.
        {
            if (ModelState.IsValid)
            {
                var newUser = new ApplicationUser
                {
                    UserName = registerViewModel.UserName,
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    Email = registerViewModel.Email,
                    City = registerViewModel.City,
                    Country = registerViewModel.Country
                };

                var result = await _userManager.CreateAsync(newUser, registerViewModel.Password);
                
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(newUser, false);
                    return RedirectToAction("index", "Home");
                }
                
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
               
            }
            return View(registerViewModel);

            //if (ModelState.IsValid)
            //{
            //    return View(registerViewModel);
            //}

            //var newUser = new ApplicationUser()
            //{
            //    UserName = registerViewModel.UserName,
            //    FirstName = registerViewModel.FirstName,
            //    LastName = registerViewModel.LastName,
            //    Email = registerViewModel.Email,
            //    City = registerViewModel.City,
            //    Country = registerViewModel.Country
            //};

            //IdentityResult result = await _userManager.CreateAsync(newUser, registerViewModel.Password);

            //if (result.Succeeded)
            //{
            //    return RedirectToAction("Index", "Home");
            //}

            //foreach (IdentityError identityError in result.Errors)
            //{
            //    ModelState.AddModelError("", identityError.Description);
            //}
            //return View(registerViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}