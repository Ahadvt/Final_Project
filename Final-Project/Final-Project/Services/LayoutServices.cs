using Final_Project.Dal;
using Final_Project.Models;
using Final_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Services
{
    public class LayoutServices
    {
        private readonly WoltDbContext _context;

        public RegisterUserVM RegisterVM { get; set; }
        public LoginUserVM LogginVM { get; set; }

        public LayoutServices(WoltDbContext context)
        {
            _context = context;
        }

        public Setting GetSetting()
        {
            Setting setting = _context.Setting.FirstOrDefault();
            return setting;
        }
    }
}
