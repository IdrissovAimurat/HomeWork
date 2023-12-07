using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Developer : Employee
    {
        public int LinesOfCodePerDay { get; set; }
        public decimal RatePerLine { get; set; }

        public Developer(string name, int age, decimal salary, int linesOfCodePerDay, decimal ratePerLine)
            : base(name, age, salary)
        {
            LinesOfCodePerDay = linesOfCodePerDay;
            RatePerLine = ratePerLine;
        }

        public override decimal CalculateAnnualSalary()
        {
            return base.CalculateAnnualSalary() + (LinesOfCodePerDay * RatePerLine * 365);
        }
    }
}
