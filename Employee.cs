using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public virtual string GetInfo()
        {
            return $"Имя: {Name}, возраст: {Age}, заработная плата: {Salary}";
        }

        public virtual decimal CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }
}
