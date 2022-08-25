using System;
using System.Collections.Generic;
using System.Globalization;
using ExerResolHerPol.Entities;

namespace ExerResolHerPol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #{0} data:", i);
                Console.Write("Outsourced (y/n)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (option == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addtionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addtionalCharge));                   
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
           
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}