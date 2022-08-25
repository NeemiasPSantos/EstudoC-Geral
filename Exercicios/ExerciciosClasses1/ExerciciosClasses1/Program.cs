using System;
using System.Globalization;

namespace ExerciciosClasses1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo calculo = new Retangulo();
            Console.WriteLine("Entre com a Largura e Altura do Retangulo: ");
            calculo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            calculo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Altura: {0}", calculo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: {0}", calculo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: {0}", calculo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
