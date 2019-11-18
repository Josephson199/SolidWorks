using System;
using System.Collections.Generic;

namespace OCP_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            var devCalculations = new List<BaseSalaryCalculator>
            {
                new SeniorDevSalaryCalculator(new DeveloperReport("Dev1", "Senior developer") {Id = 1, HourlyRate = 300.5, WorkingHours = 160 }),
                new JuniorDevSalaryCalculator(new DeveloperReport("Dev2", "Junior developer") {Id = 2, HourlyRate = 200, WorkingHours = 150 }),
                new SeniorDevSalaryCalculator(new DeveloperReport("Dev3", "Senior developer") {Id = 3, HourlyRate = 300.5, WorkingHours = 180 })
            };

            var calculator = new SalaryCalculator(devCalculations);
            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} sek");
        }
    }
}
