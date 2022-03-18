using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Restuorant
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [StringLength(30)]
        [Required]
        public string Title { get; set; }
        public string Image { get; set; }
        [StringLength(100)]
        [Required]
        public string Adress { get; set; }
        public bool IsCampaign { get; set; }
        public int? Campaign { get; set; }
        public List<Restuorant_Category> Restuorant_Categories { get; set; }
        public List<Product> Products { get; set; }
        public string AppUserId { get; set; }
       
       

    }
}
