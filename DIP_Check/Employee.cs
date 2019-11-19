﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Check
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }
    }

    public enum Position
    {
        Administrator,
        Manager,
        Executive
    }

    public enum Gender
    {
        Male,
        Female
    }
}
