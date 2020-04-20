using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int AccomId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Accom Accom { get; set; }
        public Order Order { get; set; }
        
    }
}
