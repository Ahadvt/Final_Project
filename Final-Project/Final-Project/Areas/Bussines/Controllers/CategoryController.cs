﻿using Final_Project.Dal;
using Final_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Areas.Bussines.Controllers
{
    [Area("bussines")]
    public class CategoryController : Controller
    {
        private readonly WoltDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _env;

     
        public CategoryController(WoltDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IWebHostEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(r => r.AppUserId == user.Id);
            List<ProductCategory> productCategories = _context.ProductCategories.Where(pc=>pc.RestuorantId==restuorant.Id).ToList();
            return View(productCategories);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCategory category)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(r => r.AppUserId == user.Id);
            ProductCategory NewCategory = new ProductCategory
            {
                Name = category.Name,
                RestuorantId = restuorant.Id
                
            };
            _context.ProductCategories.Add(NewCategory);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Edit(int id)
        {
            ProductCategory category = _context.ProductCategories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(ProductCategory category)
        {
            ProductCategory ExsistCategory = _context.ProductCategories.FirstOrDefault(c => c.Id == category.Id);
            if (ExsistCategory == null) return NotFound();
            if (!ModelState.IsValid) return View(ExsistCategory);
            ExsistCategory.Name = category.Name;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            ProductCategory category = _context.ProductCategories.FirstOrDefault(pc => pc.Id == id);
            if (category == null) return Json(new { status = 404 });
            _context.ProductCategories.Remove(category);
            _context.SaveChanges();
            return Json(new { status = 200 });
        }
    }
}