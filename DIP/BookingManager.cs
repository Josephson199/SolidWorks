using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class BookingManager
    {
        public readonly List<Booking> _bookings;

        public BookingManager()
        {
            _bookings = new List<Booking>();
        }

        public void AddBooking(Booking booking)
        {
            _bookings.Add(booking);
        }
    }
}
