using Final_Project.Dal;
using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Areas.Bussines.Controllers
{
    public class StoreController : Controller
    {
        private readonly WoltDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _env;

        public StoreController(WoltDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IWebHostEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _env = env;
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginUserVM loginUser)
        {
            if (!ModelState.IsValid) return View();
            if (loginUser.UserName == null || loginUser.Password == null)
            {
                ModelState.AddModelError("", "Username or password incorrect");
                return View();
            }
            AppUser user = await _userManager.FindByNameAsync(loginUser.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Username or password incorrect");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, loginUser.Password, true, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or password incorrect");
                return View();
            }
            
            return RedirectToAction(nameof(RestuorantMain));
        }
        public IActionResult Register()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RestuorantRegisterVM restuorantInfo)
        {
            ViewBag.Categories = _context.Categories.ToList();
            if (!ModelState.IsValid) return View();
            if (restuorantInfo.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "The field image is required");
                return View();
            }
            if (restuorantInfo.CategoryIds == null)
            {
                ModelState.AddModelError("CategoryIds", "can not be null");
                return View();
            }
            if (!restuorantInfo.ImageFile.IsImage())
            {
                ModelState.AddModelError("ImageFilw", "image file must be");
                return View();
            }
            if (!restuorantInfo.ImageFile.IsSizeOk(2))
            {
                ModelState.AddModelError("ImageFilw", "The field image max size 2mb");
                return View();
            }
            AppUser appUser = new AppUser
            {
                FullName = restuorantInfo.FullName,
                UserName = restuorantInfo.UserName,
                PhoneNumber = restuorantInfo.PhoneNumber,
                Email = restuorantInfo.Email,
                Role = "Restaurant"
            };
            var Result = await _userManager.CreateAsync(appUser, restuorantInfo.Password);
            if (!Result.Succeeded)
            {
                foreach (IdentityError error in Result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            Restuorant restuorant = new Restuorant();
            restuorant.Restuorant_Categories = new List<Restuorant_Category>();
            restuorant.Name = restuorantInfo.RestuorantName;
            restuorant.Adress = restuorantInfo.Adress;
            restuorant.Title = restuorantInfo.Title;
            restuorant.Description = restuorantInfo.Description;
            restuorant.WorkTime = restuorantInfo.WorkTime;
            restuorant.PhoneNumber = restuorantInfo.PhoneNumberRestuorant;
            restuorant.Image = restuorantInfo.ImageFile.SaveImage(_env.WebRootPath, "assets/image");
            AppUser User = await _userManager.FindByNameAsync(appUser.UserName);
            restuorant.AppUserId = User.Id;
            foreach (var id in restuorantInfo.CategoryIds)
            {
                Restuorant_Category restuorant_Category = new Restuorant_Category
                {
                    Restuorant = restuorant,
                    CategoryId = id
                };
                restuorant.Restuorant_Categories.Add(restuorant_Category);
            }
            _context.Restuorants.Add(restuorant);
            _context.SaveChanges();
            Restuorant CreatedRestuorant = _context.Restuorants.FirstOrDefault(cr => cr.AppUserId == User.Id);
            User.RestuorantId = CreatedRestuorant.Id;
            await _userManager.AddToRoleAsync(User, "Restaurant");
            await _userManager.UpdateAsync(User);
            return RedirectToAction("login", "bussines");
        }

        public async Task<IActionResult> RestuorantMain()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(c => c.AppUserId == user.Id);
            return View(restuorant);
        }
    }
}
