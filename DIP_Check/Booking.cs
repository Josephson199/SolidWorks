using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Check
{
    public class Booking
    {
        public string Name { get; set; }
        public Status Status { get; set; }
        public Type Type { get; set; }
    }

    public enum Type
    {
        Online,
        Classroom,
        VR
    }

    public enum Status
    {
        Completed,
        InProgress
    }
}
