using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP_Check
{
    public class BookingStatitistics
    {
        private readonly IBookingSearchable _bookingSearch;

        public BookingStatitistics(IBookingSearchable bookingSearch)
        {
            _bookingSearch = bookingSearch;
        }

        public int CountInProgressVrBookings() =>
                _bookingSearch.GetBookingCountByStatusAndType(Status.InProgress, Type.VR).Count();
    }
}
