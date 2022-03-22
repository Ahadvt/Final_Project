using Final_Project.Areas.Bussines.ViewModels;
using Final_Project.Areas.Extensions;
using Final_Project.Dal;
using Final_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Areas.Bussines.Controllers
{
    [Area("Bussines")]
    public class SettingController : Controller
    {
        private readonly WoltDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _env;

        public SettingController(WoltDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IWebHostEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _env = env;
        }
      

        public async Task<IActionResult> Edit()
        {
            ViewBag.Categories = _context.Categories.ToList();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
          
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(c => c.AppUserId == user.Id);
            RestuorantEditVm restuorantEdit = new RestuorantEditVm
            {
                AppUser=user,
                restuorant=restuorant
            };
         
            return View(restuorantEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RestuorantEditVm editVm)
        {
            ViewBag.Categories = _context.Categories.ToList();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(c => c.AppUserId == user.Id);
            RestuorantEditVm restuorantEdit = new RestuorantEditVm
            {
                AppUser = user,
                restuorant = restuorant
            };
            if (!ModelState.IsValid) return View(restuorantEdit);
         
            user.UserName = editVm.AppUser.UserName;
            user.FullName = editVm.AppUser.FullName;
            user.Email = editVm.AppUser.Email;
            user.PhoneNumber = editVm.AppUser.PhoneNumber;
            user.Email = editVm.AppUser.Email;
            await _userManager.UpdateAsync(user);
            await _signInManager.SignInAsync(user, true);

            restuorant.Name = editVm.restuorant.Name;
            restuorant.Title = editVm.restuorant.Title;
            restuorant.IsCampaign = editVm.restuorant.IsCampaign;
            restuorant.Campaign = editVm.restuorant.Campaign;
            restuorant.Adress = editVm.restuorant.Adress;
            if (editVm.ImageFile!=null)
            {
                if (!editVm.ImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "image file is required");
                    return View(restuorantEdit);
                }
                if (!editVm.ImageFile.IsSizeOk(2))
                {
                    ModelState.AddModelError("ImageFile", "image file imax size  must be 2mb");
                    return View(restuorantEdit);
                }

                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/image", restuorant.Image);
                restuorant.Image = editVm.ImageFile.SaveImage(_env.WebRootPath, "assets/image");
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Edit));
        }
    }
}
