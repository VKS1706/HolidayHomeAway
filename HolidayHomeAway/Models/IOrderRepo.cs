using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
   public interface IOrderRepo
   {
       IEnumerable<Order> AllOrders { get; }
        
       void CreateOrder(Order order);
   }
}
