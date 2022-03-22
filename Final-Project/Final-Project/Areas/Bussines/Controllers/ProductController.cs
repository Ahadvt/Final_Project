﻿using Final_Project.Areas.Extensions;
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
    [Area("bussines")]
    public class ProductController : Controller
    {
        private readonly WoltDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole>_roleManager;
        private readonly IWebHostEnvironment _env;

        public ProductController(WoltDbContext context,UserManager<AppUser> userManager,SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager,IWebHostEnvironment env)
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
            List<Product> products = _context.Products.Include(p=>p.productCategory).Where(p=>p.RestuorantId==restuorant.Id).ToList();
            return View(products);
        }

        public async Task<IActionResult> Create()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(r => r.AppUserId == user.Id);
            ViewBag.Categories = _context.ProductCategories.Where(pc => pc.RestuorantId == restuorant.Id);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(r => r.AppUserId == user.Id);
            ViewBag.Categories = _context.ProductCategories.Where(pc => pc.RestuorantId == restuorant.Id);
            if (!ModelState.IsValid) return View();
            if (product.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "The field image is required");
                return View();
            }
            if (!product.ImageFile.IsImage())
            {
                ModelState.AddModelError("ImageFile", "The field image type must be image file");
            }
            if (!product.ImageFile.IsSizeOk(2))
            {
                ModelState.AddModelError("ImageFile", "The field image max  sixe must be  2mb");
            }
            Product NewProduct = new Product
            {
                Name=product.Name,
                Price=product.Price,
                RestuorantId=restuorant.Id,
                ProductCategoryId=product.ProductCategoryId,
                
            };
               NewProduct.Image = product.ImageFile.SaveImage(_env.WebRootPath, "assets/image");
            _context.Products.Add(NewProduct);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(r => r.AppUserId == user.Id);
            ViewBag.Categories = _context.ProductCategories.Where(pc => pc.RestuorantId == restuorant.Id);
            Product product = _context.Products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(r => r.AppUserId == user.Id);
            ViewBag.Categories = _context.ProductCategories.Where(pc => pc.RestuorantId == restuorant.Id);
            Product ExsistProduct = _context.Products.FirstOrDefault(p => p.Id ==product.Id);
            if (!ModelState.IsValid) return View(ExsistProduct);
            ExsistProduct.Name = product.Name;
            ExsistProduct.Price = product.Price;
            ExsistProduct.ProductCategoryId = product.ProductCategoryId;
            if (product.ImageFile!=null)
            {
                if (!product.ImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "The field image type must be image file");
                }
                if (!product.ImageFile.IsSizeOk(2))
                {
                    ModelState.AddModelError("ImageFile", "The field image max  sixe must be  2mb");
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/image", ExsistProduct.Image);
                ExsistProduct.Image = product.ImageFile.SaveImage(_env.WebRootPath, "assets/image");
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) return Json(new { status = 404 });
            Helpers.Helper.DeleteImg(_env.WebRootPath, "asets/image", product.Image);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Json(new { status = 200 });
        }
    }

}
