using Final_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Dal
{
    public class WoltDbContext:IdentityDbContext<AppUser>
    {
        public WoltDbContext(DbContextOptions<WoltDbContext> options):base(options)
        {

        }
        //public DbSet MyProperty { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Restuorant_Category> Restuorant_Categories { get; set; }
        public DbSet<Restuorant> Restuorants { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }

    }
}
