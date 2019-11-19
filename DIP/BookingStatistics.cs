using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
    public class BookingStatistics
    {
        private readonly BookingManager _bookingManager;

        public BookingStatistics(BookingManager bookingManager)
        {
            _bookingManager = bookingManager;
        }

        public int CountVRBookingsInProgress() =>
                _bookingManager._bookings.Count(emp => emp.Status == Status.InProgress && emp.Type == Type.VR);
    }

}

