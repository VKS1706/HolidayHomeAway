using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Models;
using HolidayHomeAway.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HolidayHomeAway.Controllers
{
    [Authorize(Roles = "Administrators")]
    public class OrderManagementController : Controller
    {
        private readonly IOrderRepo _orderRepo;

        public OrderManagementController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public IActionResult Index()
        {
            var order = _orderRepo.AllOrders.OrderBy(o => o.OrderId);

            return View(order);
        }

        public IActionResult OrderManagement(string type)
        {
            IEnumerable<Order> orders;
            string currentType = string.Empty;

            if (string.IsNullOrEmpty(currentType))
            {
                orders = _orderRepo.AllOrders.OrderBy(o => o.OrderId);
                currentType = "All Orders";
            }
            else // doesnt seem to run 
            {
                orders = _orderRepo.AllOrders.Where(o => o.LastName == currentType)
                    .OrderBy(o => o.OrderId);
                currentType = _orderRepo.AllOrders.FirstOrDefault(o => o.LastName == type).LastName; // No idea 

            }

            return View(new OrderManagementViewModel
            {
                Orders = orders,
                CurrentType = currentType
            });
        }
    }
}