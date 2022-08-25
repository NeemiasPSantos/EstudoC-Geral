using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioListas1
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>(); 
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #{0}:",i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
            }
            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int increaseId = int.Parse(Console.ReadLine());
            Employee idFind = list.Find(x => x.Id == increaseId);
            if (idFind != null)
            {
                Console.Write("Enter percentage: ");
                double increase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                idFind.IncreaseSalary(increase);
            }
            else 
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine("Update list of employee: ");
            foreach (Employee employee in list) 
            {           
                Console.WriteLine(employee);
            }
        }
    }
}
