using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
    public class EmployeeStatistics
    {
        private readonly EmployeeManager _empManager;

        public EmployeeStatistics(EmployeeManager empManager)
        {
            _empManager = empManager;
        }

        public int CountFemaleManagers() =>
                _empManager._employees.Count(emp => emp.Gender == Gender.Female && emp.Position == Position.Manager);
    }

}

