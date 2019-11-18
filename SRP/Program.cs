using System;

namespace SRP
{
    static class Program
    {
        static void Main(string[] args)
        {
            var booking = new Booking();

            booking.AddParticipant(new Participant("Mattias"));

            booking.SaveToFile(Helper.AssemblyDirectory, $"{Guid.NewGuid()}.txt");
        }
    }   
}
