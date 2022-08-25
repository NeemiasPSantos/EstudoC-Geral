using AulaException.Entities;

namespace AulaException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (DD/MM/YYYY): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (DD/MM/YYYY): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error  in reservation: Check-out date must be after check-in date");
            }

            else
            {
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

                DateTime now = DateTime.Now;

                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error  in reservation: Check-out date must be after check-in date");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);

                    Console.WriteLine($"Reservation: {reservation}");
                }
            }
        }
    }
}