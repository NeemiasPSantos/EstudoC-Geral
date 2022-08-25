using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("How many employee will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #{0}:", i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
            }
            Console.WriteLine();
            Console.Write("Enter the emplyee that will have salay increase: ");
            int findId = int.Parse(Console.ReadLine());
            Employee employee = list.Find(x => x.Id == findId);

            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist.");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employee: ");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
