using System;

namespace ExercicioEstruturaSequencial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero da soma: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero da soma: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 + n2;

            Console.WriteLine();
            Console.WriteLine("SOMA: {0}", resultado);
        }
    }
}
