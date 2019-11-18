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
                new DeveloperReport("Dev1", "Senior developer") {Id = 1, HourlyRate  = 300.5, WorkingHours = 160 },
                new DeveloperReport("Dev2", "Junior developer") {Id = 2, HourlyRate  = 200, WorkingHours = 150 },
                new DeveloperReport("Dev3", "Senior developer") {Id = 3, HourlyRate  = 300.5, WorkingHours = 180 }
            };

            var calculator = new SalaryCalculator(devReports);
            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} sek");
            Console.ReadKey();
        }
    }
}
