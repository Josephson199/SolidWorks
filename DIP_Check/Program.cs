using System;

namespace DIP_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookingManager = new BookingManager();
            bookingManager.AddBooking(new Booking { Name = "Säkra lyft", Type = Type.VR, Status = Status.InProgress });
            bookingManager.AddBooking(new Booking { Name = "Truckkörkort", Type = Type.Online, Status = Status.Completed });

            var stats = new BookingStatitistics(bookingManager);
            Console.WriteLine($"Number of VR bookings in progress: {stats.CountInProgressVrBookings()}");
        }
    }
}
