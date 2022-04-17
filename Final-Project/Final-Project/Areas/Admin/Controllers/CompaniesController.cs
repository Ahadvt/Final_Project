using Final_Project.Dal;
using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class CompaniesController : Controller
    {
        private readonly WoltDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public CompaniesController(WoltDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Restaurant()
        {
            StoreCourierRestaurant company = new StoreCourierRestaurant
            {
                Users=_userManager.Users.Where(u=>u.Role== "Restaurant").ToList(),
                Restuorants=_context.Restuorants.ToList()
            };
            return View(company);
        }
        public IActionResult Store()
        {
            StoreCourierRestaurant company = new StoreCourierRestaurant
            {
                Users = _userManager.Users.Where(u => u.Role == "Store").ToList(),
                Stores = _context.Stores.ToList()
            };
            return View(company);
        }
        public IActionResult Courier()
        {
            StoreCourierRestaurant company = new StoreCourierRestaurant
            {
                Users = _userManager.Users.Where(u => u.Role == "Courier").ToList(),
                
            };
            return View(company);
        }
        public async Task<IActionResult> ChangeStatus(string userid)
        {
            AppUser user = await _userManager.FindByIdAsync(userid);
            if (user == null) return Json(new { status = 404 });
            if (user.LoginStatus)
            {
                user.LoginStatus = false;
                await _userManager.UpdateAsync(user);
                return Json(new { status = 200 });
            }
            else
            {
                user.LoginStatus = true;
                await  _userManager.UpdateAsync(user);
                return Json(new { status = 201 });
            }

        }

        public async Task<IActionResult> Delete(string userid)
        {
            AppUser user = await _userManager.FindByIdAsync(userid);
            if (user == null) return Json(new {status=404});
            if (user.Role == "Restaurant")
            {
                Restuorant restaurant = _context.Restuorants.FirstOrDefault(r => r.AppUserId == user.Id);

                List<ProductCategory> productCategories = _context.ProductCategories.Where(pc=>pc.RestuorantId==restaurant.Id).ToList();
                foreach (var item in productCategories)
                {

                    _context.ProductCategories.Remove(item);
                }
                _context.SaveChanges();
                _context.Restuorants.Remove(restaurant);
                
                
            }
            if (user.Role == "Store")
            {
                Store store = _context.Stores.Include(s=>s.ProductCategories).FirstOrDefault(r => r.AppUserId == user.Id);
                List<ProductCategory> productCategories = _context.ProductCategories.Where(pc => pc.RestuorantId == store.Id).ToList();
                foreach (var item in productCategories)
                {

                    _context.ProductCategories.Remove(item);
                }
                _context.SaveChanges();
                _context.Stores.Remove(store);
            }

            await _userManager.DeleteAsync(user);
         
                   
            _context.SaveChanges();
            return Json(new {status=200 });
        }
    }
}
