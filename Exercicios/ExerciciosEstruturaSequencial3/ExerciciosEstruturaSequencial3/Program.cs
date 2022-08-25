using System;

namespace ExerciciosEstruturaSequencial3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de D: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int diferenca = (a * b) - (c * d);

            Console.WriteLine("DIFERENÇA: {0}", diferenca);
        }
    }
}
