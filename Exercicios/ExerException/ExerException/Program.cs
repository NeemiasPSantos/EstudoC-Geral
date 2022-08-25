using System.Globalization;
using ExerException.Entities;
using ExerException.Entities.Exceptions;

namespace ExerException
{
    public class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account date: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdaw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(withdaw);

                Console.WriteLine(acc);
            }
            catch (DomainException e) 
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
        }
    }
}