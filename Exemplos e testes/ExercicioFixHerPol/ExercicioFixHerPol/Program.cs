using ExercicioFixHerPol.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixHerPol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(option == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product imported = new ImportedProduct(name, price, customsFee);
                    product.Add(imported);
                }
                else if(option == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureD = DateTime.Parse(Console.ReadLine());
                    Product used = new UsedProduct(name, price, manufactureD);
                    product.Add(used);
                }
                else
                {
                    Product common = new Product(name, price);
                    product.Add(common);
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product products in product)
            {
                Console.WriteLine(products.PriceTag());
            }
        }
    }
}