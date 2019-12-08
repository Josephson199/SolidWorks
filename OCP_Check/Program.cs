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
                new SeniorDevSalaryCalculator(new DeveloperReport("Ada Lovelace") {Id = 1, HourlyRate = 300.5, WorkingHours = 160, Level = Level.Senior }),
                new JuniorDevSalaryCalculator(new DeveloperReport("Tim Berners-Lee") {Id = 2, HourlyRate = 200, WorkingHours = 150, Level = Level.Junior }),
                new SeniorDevSalaryCalculator(new DeveloperReport("Alan Turing") {Id = 3, HourlyRate = 300.5, WorkingHours = 180, Level = Level.Senior })
            };

            var calculator = new SalaryCalculator(devCalculations);
            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} sek");
        }
    }
}
