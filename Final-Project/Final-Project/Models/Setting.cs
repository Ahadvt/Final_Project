using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Logo { get; set; }
        [StringLength(100)]

        public string FacebbokLink { get; set; }
        [StringLength(100)]

        public string InstagramLink { get; set; }
        [StringLength(100)]

        public string TwitterLink { get; set; }
        [StringLength(100)]

        public string LInkedinLink { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }



    }
}
