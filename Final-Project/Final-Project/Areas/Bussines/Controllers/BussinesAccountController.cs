using Final_Project.Areas.Bussines.ViewModels;
using Final_Project.Areas.Extensions;
using Final_Project.Dal;
using Final_Project.Models;
using Final_Project.ViewModels;
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
    public class BussinesAccountController : Controller
    {
        private readonly WoltDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _env;

        public BussinesAccountController(WoltDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IWebHostEnvironment env)
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

            if (user.Role == "Store")
            {
                return RedirectToAction(nameof(StoreSettingEdit));
            }
            return RedirectToAction(nameof(RestuorantMain));
        }
        public IActionResult CreateRestuorant()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRestuorant(RestuorantRegisterVM restuorantInfo)
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
           await _signInManager.SignInAsync(User, true);
            return RedirectToAction(nameof(RestuorantMain));
        }
        public async Task<IActionResult> RestuorantMain()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(c => c.AppUserId == user.Id);
            return View(restuorant);
        }
        public async Task<IActionResult> RestuorantSettingEdit()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Campaigns = _context.Campaigns.ToList();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.Include(r => r.Restuorant_Categories).FirstOrDefault(c => c.AppUserId == user.Id);
            RestuorantEditVm restuorantEdit = new RestuorantEditVm
            {
                AppUser = user,
                restuorant = restuorant
            };
            return View(restuorantEdit);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RestuorantSettingEdit(RestuorantEditVm editVm)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Campaigns = _context.Campaigns.ToList();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.Include(r => r.Restuorant_Categories).FirstOrDefault(c => c.AppUserId == user.Id);
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
            restuorant.IsDeliveryFree = editVm.restuorant.IsDeliveryFree;
            restuorant.CampaignId = editVm.restuorant.CampaignId;
            restuorant.Description = editVm.restuorant.Description;
            restuorant.PhoneNumber = editVm.restuorant.PhoneNumber;
            restuorant.Adress = editVm.restuorant.Adress;
            restuorant.WorkTime = editVm.restuorant.WorkTime;
            if (editVm.CategoryIds != null)
            {
                List<Restuorant_Category> RemoveAbleCategories = restuorant.Restuorant_Categories.Where(rc => !editVm.CategoryIds.Contains(rc.CategoryId)).ToList();
                restuorant.Restuorant_Categories.RemoveAll(rc => RemoveAbleCategories.Any(rmc => rmc.Id == rc.Id));
                foreach (var categoryId in editVm.CategoryIds)
                {
                    Restuorant_Category restuorant_Category = restuorant.Restuorant_Categories.FirstOrDefault(rc => rc.CategoryId == categoryId);
                    if (restuorant_Category == null)
                    {
                        Restuorant_Category NewRestuorantCategory = new Restuorant_Category
                        {
                            RestuorantId = restuorant.Id,
                            CategoryId = categoryId
                        };
                        restuorant.Restuorant_Categories.Add(NewRestuorantCategory);
                    }
                }
            }
            if (editVm.ImageFile != null)
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
            TempData["message"] = "Data saved";
            return RedirectToAction(nameof(restuorantEdit));
        }

        public IActionResult Order()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ShowOrders(string userid,int restuorantid)
        {
            Order order = _context.Orders.Include(o => o.OrderItems).ThenInclude(oi=>oi.Product).FirstOrDefault(o => o.AppUserId == userid && o.RestuorantId == restuorantid);
            //if (orderItems == null) return NotFound();
            return Json(order);
            
        }
        public IActionResult CreateStore()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStore(StoreRegisterVM storeRegister)
        {

            if (!ModelState.IsValid) return View();
            if (storeRegister.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "The field image is required");
                return View();
            }
            if (!storeRegister.ImageFile.IsImage())
            {
                ModelState.AddModelError("ImageFilw", "image file must be");
                return View();
            }
            if (!storeRegister.ImageFile.IsSizeOk(2))
            {
                ModelState.AddModelError("ImageFilw", "The field image max size 2mb");
                return View();
            }
            AppUser appUser = new AppUser
            {
                FullName = storeRegister.FullName,
                UserName = storeRegister.UserName,
                PhoneNumber = storeRegister.PhoneNumber,
                Email = storeRegister.Email,
                Role = "Store"
            };
            var Result = await _userManager.CreateAsync(appUser, storeRegister.Password);
            if (!Result.Succeeded)
            {
                foreach (IdentityError error in Result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            Store store = new Store();
            store.Name = storeRegister.StoreName;
            store.Adress = storeRegister.Adress;
            store.Title = storeRegister.Title;
            store.Description = storeRegister.Description;
            store.WorkTime = storeRegister.WorkTime;
            store.PhoneNumber = storeRegister.PhoneNumberRestuorant;
            store.Image = storeRegister.ImageFile.SaveImage(_env.WebRootPath, "assets/image");
            AppUser User = await _userManager.FindByNameAsync(appUser.UserName);
            store.AppUserId = User.Id;

            _context.Stores.Add(store);
            _context.SaveChanges();
            Store CreatedStore = _context.Stores.FirstOrDefault(cr => cr.AppUserId == User.Id);
            User.StoreId = CreatedStore.Id;
            await _userManager.AddToRoleAsync(User, "Store");
            await _userManager.UpdateAsync(User);
            await _signInManager.SignInAsync(User, true);
            return RedirectToAction(nameof(StoreMain));
        }

        public async Task<IActionResult> StoreMain()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Store store = _context.Stores.FirstOrDefault(c => c.AppUserId == user.Id);
            return View(store);

        }

        public async Task<IActionResult> StoreSettingEdit()
        {
           
            ViewBag.Campaigns = _context.Campaigns.ToList();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Store store = _context.Stores.FirstOrDefault(c => c.AppUserId == user.Id);
            StoreEditVM storeEdit = new StoreEditVM
            {
                AppUser = user,
                Store = store
            };
            return View(storeEdit);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> StoreSettingEdit(StoreEditVM storeEditVM)
        {
            ViewBag.Campaigns = _context.Campaigns.ToList();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Store store = _context.Stores.FirstOrDefault(c => c.AppUserId == user.Id);
            StoreEditVM storeEdit = new StoreEditVM
            {
                AppUser = user,
                Store = store
            };
            if (!ModelState.IsValid) return View(storeEdit);
            user.UserName = storeEditVM.AppUser.UserName;
            user.FullName = storeEditVM.AppUser.FullName;
            user.Email = storeEditVM.AppUser.Email;
            user.PhoneNumber = storeEditVM.AppUser.PhoneNumber;
            user.Email = storeEditVM.AppUser.Email;
            await _userManager.UpdateAsync(user);
            await _signInManager.SignInAsync(user, true);
            store.Name = storeEditVM.Store.Name;
            store.Title = storeEditVM.Store.Title;
            store.IsDeliveryFree = storeEditVM.Store.IsDeliveryFree;
            store.CampaignId = storeEditVM.Store.CampaignId;
            store.Description = storeEditVM.Store.Description;
            store.PhoneNumber = storeEditVM.Store.PhoneNumber;
            store.Adress = storeEditVM.Store.Adress;
            store.WorkTime = storeEditVM.Store.WorkTime;
          
            if (storeEditVM.ImageFile != null)
            {
                if (!storeEditVM.ImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "image file is required");
                    return View(storeEdit);
                }
                if (!storeEditVM.ImageFile.IsSizeOk(2))
                {
                    ModelState.AddModelError("ImageFile", "image file imax size  must be 2mb");
                    return View(storeEdit);
                }

                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/image", store.Image);
                store.Image = storeEditVM.ImageFile.SaveImage(_env.WebRootPath, "assets/image");
            }
            _context.SaveChanges();
            TempData["message"] = "Data saved";
            return RedirectToAction(nameof(StoreSettingEdit));
        }

    }
}
