using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Employee : IPayable
    {
        public string Name { get; set; }
        public decimal MonthlySalary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            MonthlySalary = salary;
        }

        public decimal CalculatePay()
        {
            return MonthlySalary; // Fixed monthly salary
        }

        public override string ToString()
        {
            return $"Employee: {Name}";
        }
    }

}
