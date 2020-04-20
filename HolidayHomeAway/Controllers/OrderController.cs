using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HolidayHomeAway.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepo _orderRepo;
        private readonly Booking _booking;

        public OrderController(IOrderRepo orderRepo, Booking booking)
        {
            _orderRepo = orderRepo;
            _booking = booking;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _booking.GetBookingItems();
            _booking.BookingItems = items;

            if (_booking.BookingItems.Count == 0)
            {
                ModelState.AddModelError("", "There are no holidays booked at this time");
            }

            if (ModelState.IsValid)
            {
                _orderRepo.CreateOrder(order);
                _booking.ClearBook();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order!";
            return View();
        }
    }
}