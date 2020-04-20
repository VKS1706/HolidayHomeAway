using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly Booking _booking;

        public OrderRepo(AppDbContext appDbContext, Booking booking)
        {
            _appDbContext = appDbContext;
            _booking = booking;
        }


        public void CreateOrder(Order order)
        {
            order.DateOrderPlaced = DateTime.Now;

            _appDbContext.Orders.Add(order);

            var bookingItems = _booking.BookingItems;

            foreach (var bookingItem in bookingItems)
            {
                var orderDetail = new OrderDetails()
                {
                    Amount = bookingItem.Amount,
                    AccomId = bookingItem.Accom.Id,
                    OrderId = order.OrderId,
                    Price = bookingItem.Accom.Price
                };

                _appDbContext.OrderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}
