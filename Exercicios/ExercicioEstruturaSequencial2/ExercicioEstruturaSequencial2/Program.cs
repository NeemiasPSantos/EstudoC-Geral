using System;
using System.Globalization;

namespace ExercicioEstruturaSequencial2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;           

            Console.WriteLine("Informe o valor da raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine();
            Console.WriteLine("A = {0}", area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
