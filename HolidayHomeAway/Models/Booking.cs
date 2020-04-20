using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HolidayHomeAway.Models
{
    public class Booking
    {
        private readonly AppDbContext _appDbContext;

        public string BookingId { get; set; }

        public List<BookingItem> BookingItems { get; set; }

        private Booking(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static Booking GetBooking(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string bookId = session.GetString("BookId") ?? Guid.NewGuid().ToString();

            session.SetString("BookId", bookId);

            return new Booking(context) { BookingId = bookId };
        }

        public void AddToBook(Accom accom, int amount)
        {
            var bookingItem =
                _appDbContext.BookingItems.SingleOrDefault(
                   b => b.Accom.Id == accom.Id && b.BookingId == BookingId); //Check ID can be found
            if (bookingItem == null) // if not add to booking
            {
                bookingItem = new BookingItem
                {
                    BookingId = BookingId,
                    Accom = accom,
                    Amount = 1
                };

                _appDbContext.BookingItems.Add(bookingItem);
            }
            else
            {
                bookingItem.Amount++;
            }

            _appDbContext.SaveChanges(); // add to database
        }

        public int RemoveFromBook(Accom accom)
        {
            var bookingItem =
                _appDbContext.BookingItems.SingleOrDefault(
                    b => b.Accom.Id == accom.Id && b.BookingId == BookingId); //Check ID can be found

            var localAmount = 0;

            if (bookingItem != null)
            {
                if (bookingItem.Amount > 1)
                {
                    bookingItem.Amount--;
                    localAmount = bookingItem.Amount;
                }
                else
                {
                    _appDbContext.BookingItems.Remove(bookingItem);
                }
            }

            return localAmount;
        }

        public List<BookingItem> GetBookingItems()
        {
            return BookingItems ??(BookingItems= _appDbContext.BookingItems
                .Where(b => b.BookingId == BookingId)
                .Include(s => s.Accom)
                .ToList());
        }

        public void ClearBook() // Remove all items
        {
            var bookItems = _appDbContext
                .BookingItems
                .Where(book => book.BookingId == BookingId);

            _appDbContext.BookingItems.RemoveRange(bookItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetBookingTotal() // return final total
        {
            var total = _appDbContext.BookingItems.Where(b => b.BookingId == BookingId)
                .Select(b => b.Accom.Price * b.Amount).Sum();
            return total;
        }
    }
}
