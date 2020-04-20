using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Models;
using HolidayHomeAway.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HolidayHomeAway.Controllers
{
    public class BookingController : Controller
    {
        private readonly IAccomRepo _accomRepo;
        private readonly Booking _booking;

        public BookingController(IAccomRepo accomRepo, Booking booking)
        {
            _accomRepo = accomRepo;
            _booking = booking;
        }
        public ViewResult Index() // return booking view
        {
            var items = _booking.GetBookingItems();
            _booking.BookingItems = items;

            var bookingViewModel = new BookingViewModel
            {
                Booking = _booking,
                BookingTotal = _booking.GetBookingTotal()

            };
            return View(bookingViewModel);
        }

        public RedirectToActionResult AddToBooking(int accomId)
        {
            var selectedBook = _accomRepo.AllAccom.FirstOrDefault(a => a.Id == accomId);

            if (selectedBook != null)
            {
                _booking.AddToBook(selectedBook, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromBooking(int accomId)
        {
            var selectedbook = _accomRepo.AllAccom.FirstOrDefault(a => a.Id == accomId);

            if (selectedbook != null)
            {
                _booking.RemoveFromBook(selectedbook);
            }

            return RedirectToAction("Index");
        }
    }
}
