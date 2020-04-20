using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Models;

namespace HolidayHomeAway.ViewModels
{
    public class BookingViewModel
    {
        public Booking Booking { get; set; }
        public decimal BookingTotal { get; set; }
    }
}
