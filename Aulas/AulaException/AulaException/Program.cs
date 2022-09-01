using AulaException.Entities;
using AulaException.Entities.Exception;

namespace AulaException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (DD/MM/YYYY): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (DD/MM/YYYY): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);

                Console.WriteLine($"Reservation: {reservation}");


                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation: ");
                Console.Write("Room number: ");
                number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (DD/MM/YYYY): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (DD/MM/YYYY): ");
                checkOut = DateTime.Parse(Console.ReadLine());
            }
            catch (DomainException error)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(error.Message);
            }
        }
    }
}