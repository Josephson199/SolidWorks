using System;
using System.Collections.Generic;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var devReports = new List<DeveloperReport>
            {
                //Trivia Larry Page CEO of Alphabet
                //Dennis Ritchie, founder of the C programming language and CO Developer of UNIX
                //Ken Thompson, designed and implemented the original UNIX OS.
                new DeveloperReport("Larry Page") {Id = 1, HourlyRate  = 300.5, WorkingHours = 160, Level = Level.Senior },
                new DeveloperReport("Dennis Ritchie") {Id = 2, HourlyRate  = 200, WorkingHours = 150, Level = Level.Junior },
                new DeveloperReport("Ken Thompson") {Id = 3, HourlyRate  = 300.5, WorkingHours = 180, Level = Level.Senior }
            };

            var calculator = new SalaryCalculator(devReports);
            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} sek");
            Console.ReadKey();
        }
    }
}
