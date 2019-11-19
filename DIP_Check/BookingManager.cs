using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP_Check
{
    public class BookingManager : IBookingSearchable
    {
        private readonly List<Booking> _bookings;

        public BookingManager()
        {
            _bookings = new List<Booking>();
        }

        public void AddBooking(Booking booking)
        {
            _bookings.Add(booking);
        }

        public IEnumerable<Booking> GetBookingCountByStatusAndType(Status status, Type type)
        {
            return _bookings.Where(b => b.Status == status && b.Type == type);
        }
    }
}
