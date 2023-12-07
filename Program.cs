using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Аймурат aka 'AntiFashist'", 20, 200000);
            var manager = new Manager("Ислам aka 'JS Developer'", 20, 400000, 70000);
            var developer = new Developer("Ильяська aka 'MainAntiFashist'", 20, 300000, 650, 0.5m);
            

            Console.WriteLine(employee.GetInfo());
            Console.WriteLine($"Годовая зарплата сотрудника: {employee.CalculateAnnualSalary()} \n");
     //       Console.WriteLine("\n");

            Console.WriteLine(manager.GetInfo());
            Console.WriteLine($"Годовая зарплата манагера с бонусом: {manager.CalculateAnnualSalary()} \n");

            Console.WriteLine(developer.GetInfo());
            Console.WriteLine($"Годовая зарплата девелапера с бонусом: {developer.CalculateAnnualSalary()} \n");
            Console.ReadKey();
        }
    }
}
