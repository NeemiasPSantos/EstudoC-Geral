using ExerAbstract.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExerAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the name of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i}:");
                Console.Write("Individual or company (i/c)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(option == 'i')
                {
                    Console.Write("Health expendituries: ");
                    double healthExpendituries = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpendituries));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double sum = 0.0;
            foreach (TaxPayer taxes in list)
            {
                sum += taxes.Tax();
                Console.WriteLine(taxes.Tag());
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}