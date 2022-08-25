using AulaEnumeracao1.Entities;
using AulaEnumeracao1.Entities.Enums;

namespace AulaEnumeracao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);

            Console.WriteLine(os);
        }
    }
}