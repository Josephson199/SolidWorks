using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Check
{
    public interface IBookingSearchable
    {
        IEnumerable<Booking> GetBookingCountByStatusAndType(Status status, Type type);
    }
}
