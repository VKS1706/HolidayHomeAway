using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Models;
using HolidayHomeAway.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HolidayHomeAway.Components
{
    public class BookingSummary : ViewComponent
    {
        private readonly Booking _booking;

        public BookingSummary(Booking booking)
        {
            _booking = booking;
        }

        public IViewComponentResult Invoke()
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


    }
}
