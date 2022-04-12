using Final_Project.Dal;
using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Controllers
{
    
    public class StoreController : Controller
    {
        private readonly WoltDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContext;


        public StoreController(WoltDbContext context, UserManager<AppUser> userManager, IHttpContextAccessor httpContext)
        {
            _context = context;
            _userManager = userManager;
            _httpContext = httpContext;
        }
        public IActionResult Index()
        {
            List<Store> Stores = _context.Stores.ToList();
            return View(Stores);
        }
        public async Task<IActionResult> Sort(bool isdelivery, bool isdicount)
        {
            List<Store> stores = _context.Stores.Where(r => r.IsDeliveryFree == isdelivery && r.IsCampaign == isdicount).ToList();
            return Json(stores);
        }

        public async Task<IActionResult> Details(int id)
        {
            BasketVM basketVM = new BasketVM
            {
                TotalPrice = 0,
                Count = 0,
                BasketItemVMs = new List<BasketItemVM>()
            };
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                List<BasketItem> basketItem = _context.BasketItems.Where(b => b.AppUserId == user.Id && b.StoreId == id).ToList();

                foreach (BasketItem item in basketItem)
                {
                    Product product = _context.Products.FirstOrDefault(p => p.Id == item.ProductId);
                    if (product != null)
                    {
                        BasketItemVM basketItemVM = new BasketItemVM
                        {
                            Count = item.Count,
                            Product = _context.Products.FirstOrDefault(p => p.Id == item.ProductId),

                        };
                        basketItemVM.Price = basketItemVM.Product.Price;
                        basketVM.Count++;
                        basketVM.TotalPrice += basketItemVM.Price * basketItemVM.Count;
                        basketVM.BasketItemVMs.Add(basketItemVM);
                    }
                }
            }
            DetailsVM details = new DetailsVM
            {
                Store = _context.Stores.Include(r => r.ProductCategories).Include(r => r.Products).Include(r => r.BasketItems).FirstOrDefault(r => r.Id == id),
                BasketVM = basketVM
            };
            return View(details);
        }
        [HttpPost]
        public async Task<IActionResult> AddToBassket(int id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (User.Identity.IsAuthenticated && User.IsInRole("User"))
            {
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                BasketItem basketItem = _context.BasketItems.FirstOrDefault(b => b.ProductId == product.Id && b.AppUserId == appUser.Id && b.StoreId == product.StoreId);
                if (basketItem == null)
                {
                    basketItem = new BasketItem
                    {
                        AppUserId = appUser.Id,
                        ProductId = product.Id,
                        StoreId = product.StoreId,
                        Count = 1
                    };
                    _context.BasketItems.Add(basketItem);
                }
                else
                {
                    basketItem.Count++;
                }
                _context.SaveChanges();
            }

            return Json(new { status = 200 });
        }

        [HttpPost]
        public async Task<IActionResult> ShowBasket(int id)
        {

            BasketVM basketVM = new BasketVM
            {
                TotalPrice = 0,
                Count = 0,
                BasketItemVMs = new List<BasketItemVM>()
            };
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                Product productEx = _context.Products.FirstOrDefault(p => p.Id == id);

                List<BasketItem> basketItem = _context.BasketItems.Where(b => b.AppUserId == user.Id && b.StoreId == productEx.StoreId).ToList();

                foreach (BasketItem item in basketItem)
                {
                    Product product = _context.Products.FirstOrDefault(p => p.Id == item.ProductId);
                    if (product != null)
                    {
                        BasketItemVM basketItemVM = new BasketItemVM
                        {
                            Count = item.Count,
                            Product = _context.Products.FirstOrDefault(p => p.Id == item.ProductId),

                        };
                        basketItemVM.Price = basketItemVM.Product.Price;
                        basketVM.Count++;
                        basketVM.TotalPrice += basketItemVM.Price * basketItemVM.Count;
                        basketVM.BasketItemVMs.Add(basketItemVM);
                    }
                }
            }
            return Json(basketVM);
        }

        [HttpPost]
        public async Task<IActionResult> Decrease(int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            BasketItem basketItem = _context.BasketItems.FirstOrDefault(b => b.ProductId == id && b.AppUserId == user.Id);
            if (basketItem.Count == 1)
            {
                _context.BasketItems.Remove(basketItem);
            }
            else
            {
                basketItem.Count--;
            }
            _context.SaveChanges();
            return Json(new { status = 200 });
        }
    }
}
