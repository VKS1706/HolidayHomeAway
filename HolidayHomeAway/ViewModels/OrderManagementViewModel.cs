using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayHomeAway.Models;

namespace HolidayHomeAway.ViewModels
{
    public class OrderManagementViewModel
    {
        public IEnumerable<Order> Orders { get; set; }

        public string CurrentType { get; set; }
    }
}
