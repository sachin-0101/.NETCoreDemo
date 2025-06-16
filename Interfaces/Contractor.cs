using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Contractor : IPayable
    {
        public string Name { get; set; }
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Contractor(string name, decimal rate, int hours)
        {
            Name = name;
            HourlyRate = rate;
            HoursWorked = hours;
        }

        public decimal CalculatePay()
        {
            return HourlyRate * HoursWorked;
        }

        public override string ToString()
        {
            return $"Contractor: {Name}";
        }
    }
}
