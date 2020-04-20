using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
    public class BookingItem
    {
        public int BookingItemId { get; set; }
        public Accom Accom { get; set; }
        public int Amount { get; set; }
        public string BookingId { get; set; }
    }
}
