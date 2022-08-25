using System;
using System.Globalization;

namespace ExerciciosEstruturaSequencial6
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Informe os 3 pontos flutuantes sendo ele A, B e C: ");
            string[] floatPoint = Console.ReadLine().Split(' ');
            double a = double.Parse(floatPoint[0], CultureInfo.InvariantCulture);
            double b = double.Parse(floatPoint[1], CultureInfo.InvariantCulture);
            double c = double.Parse(floatPoint[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2;
            double circulo = Math.Pow(c, 2.0) * pi;
            double trapezio = (a + b) * c / 2;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine();
            Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: {0}", retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
