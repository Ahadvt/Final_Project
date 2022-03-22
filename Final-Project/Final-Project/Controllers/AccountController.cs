using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Controllers
{
 
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

    
        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserVM register)
        {
            AppUser user = new AppUser
            {
                FullName=register.FullName,
                UserName=register.UserName,
                Email=register.Email,
                PhoneNumber=register.PhoneNumber,
                Role="User"
                
            };
            IdentityResult result = await _userManager.CreateAsync(user, register.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return Json(new { status = result.Errors });
            }
            await _userManager.AddToRoleAsync(user,"User");
            await _signInManager.SignInAsync(user, true);

            return Json(new {status=200 });  
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserVM login)
        {
            if (login.UserName == null || login.Password == null) return Json(new { status = 404 });
            AppUser user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null) return Json(new { status = 404 });
            if (user.Role != "User") return Json(new { status = 404 });
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, login.Password, login.RememberMe, true);
            if (!result.Succeeded)
            {
                if (result.IsLockedOut)
                {
                    return Json("your account is blocked 5 minute");
                }
                else
                {
                    return Json(new { status = 404 });
                }
            }
            return Json(new { status = 200 });
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index","home");
        }
        public async Task<IActionResult> EditUser()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            EditUserVM editUser = new EditUserVM
            {
                FullName = user.FullName,
                UserName=user.UserName,
                Email=user.Email,
                PhoneNumber=user.PhoneNumber
                
            };
            return View(editUser);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserVM editUser)
        {
            AppUser ExsistUser = await _userManager.FindByNameAsync(User.Identity.Name);
            EditUserVM EditUser = new EditUserVM
            {
                FullName = ExsistUser.FullName,
                UserName = ExsistUser.UserName,
                Email = ExsistUser.Email,
                PhoneNumber = ExsistUser.PhoneNumber

            };
            if(ExsistUser.UserName!=editUser.UserName&& await _userManager.FindByNameAsync(editUser.UserName) != null)
            {
                ModelState.AddModelError("", $"The {editUser.UserName} is alrady taken");
                return View(editUser);
            }
            if (!ModelState.IsValid) return View(EditUser);
            ExsistUser.UserName = editUser.UserName;
            ExsistUser.FullName = editUser.FullName;
            ExsistUser.Email = editUser.Email;
            ExsistUser.PhoneNumber = editUser.PhoneNumber;
           
            if (!string.IsNullOrEmpty(editUser.CurrentPassword))
            {
                if (editUser.Password == null)
                {
                    ModelState.AddModelError("Password", "The field password is required");
                    return View(EditUser);
                }
                IdentityResult result = await _userManager.ChangePasswordAsync(ExsistUser, editUser.CurrentPassword, editUser.Password);
             
                if (!result.Succeeded)
                {
                    foreach (IdentityError Error in result.Errors)
                    {
                        ModelState.AddModelError("", Error.Description);

                    }
                    return View(EditUser);
                }
                await _signInManager.PasswordSignInAsync(ExsistUser, editUser.Password, true, true);
            }
            await _userManager.UpdateAsync(ExsistUser);
            await _signInManager.SignInAsync(ExsistUser, true);
            TempData["message"] = "Data saved";
            return RedirectToAction(nameof(EditUser));
        }
    }
}
