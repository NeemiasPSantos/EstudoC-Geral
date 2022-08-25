using System;
using System.Globalization;

namespace ExercicioStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor x = new Conversor();
            
            Console.Write("Qual é a cotação do dolar? ");
            Conversor.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Console.Write("Quanto dolares você deseja comprar? ");
            Conversor.Dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine(x);
        }
    }
}
