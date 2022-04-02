using Final_Project.Dal;
using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNet.SignalR.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading.Tasks;

namespace Final_Project.Hubs
{
    public class OrderHub : Hub
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly WoltDbContext _context;


        public OrderHub(UserManager<AppUser> userManager, WoltDbContext context, IHubContext<OrderHub> hubContext)
        {
            _userManager = userManager;
            _context = context;

        }

        public async Task OrderProduct(string restuorantid, string Isdelivery, string Adress, string IsCard)
        {
            bool IsDelivery = bool.Parse(Isdelivery);
            bool Iscard = bool.Parse(IsCard);
            int Restuorantid = int.Parse(restuorantid);
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(r => r.Id == Restuorantid);
            AppUser user = await _userManager.FindByNameAsync(Context.User.Identity.Name);
            AppUser ResUser = await _userManager.FindByIdAsync(restuorant.AppUserId);
            List<BasketItem> basketitems = _context.BasketItems.Include(bi => bi.Product).Include(bi => bi.AppUser).Include(bi => bi.Restuorant).Include(bi => bi.Store).Where(b => b.AppUserId == user.Id && b.RestuorantId == restuorant.Id).ToList();
            Order order = new Order
            {
                AppUserId = user.Id,
                RestuorantId = restuorant.Id,
                IsDelivery = IsDelivery,
                IsCard = Iscard,
                CardMonth = "1",
                CardYear = "1",
                CardNumber = 1,
                Owner = "ahad",
                Cvv = 78,
                Date = DateTime.UtcNow.AddHours(3),
            };
            if (Adress != null)
            {
                order.Adress = Adress;
            }
            foreach (var item in basketitems)
            {
                order.TotalPrice += item.Count * item.Product.Price;
                OrderItems orderItems = new OrderItems
                {
                    Order = order,
                    Product = item.Product,
                    AppUserId = user.Id,
                    RestuorantId = restuorant.Id,
                    Count=item.Count
                    
                    
                };
                
                _context.OrderItems.Add(orderItems);
            }
            //_context.BasketItems.RemoveRange(basketitems);
            _context.Orders.Add(order);
            _context.SaveChanges();
            await Clients.Client(ResUser.ConnectionId).SendAsync("thereisorder", new
            {
                restuorantid = restuorantid,
                userid = user.Id
            });


        }
        public async Task OrderAccept(string userId)
        {
            AppUser ResUser = await _userManager.FindByNameAsync(Context.User.Identity.Name);
            Restuorant restuorant = _context.Restuorants.FirstOrDefault(r => r.AppUserId == userId);
            AppUser user = await _userManager.FindByIdAsync(userId);
            Order order = _context.Orders.FirstOrDefault(o => o.AppUserId == user.Id);
            order.IsAccept = true;
            _context.SaveChanges();
            await Clients.Client(user.ConnectionId).SendAsync("orderaccept");
        }



        public override Task OnConnectedAsync()
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser user = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;
                user.ConnectionId = Context.ConnectionId;
                var Result = _userManager.UpdateAsync(user).Result;
                Clients.All.SendAsync("UserConnected", user.Id);
            }
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser user = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;
                user.ConnectionId = null;
                var Result = _userManager.UpdateAsync(user).Result;
                Clients.All.SendAsync("UserConnected", user.Id);
            }
            return base.OnDisconnectedAsync(exception);
        }

    }
}
