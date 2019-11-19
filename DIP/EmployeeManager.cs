using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class EmployeeManager
    {
        public readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}
