using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int ProductCategoryId { get; set; }
        public int RestuorantId { get; set; }
        public Restuorant restuorant { get; set; }
        public ProductCategory productCategory { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<BasketItem> V { get; set; }

    }
}
