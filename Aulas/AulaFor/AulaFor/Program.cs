using System;

namespace AulaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanto numero inteiros você vai digitar? ");
            int n1 = int.Parse(Console.ReadLine());
            int soma = 0;

            for(int i = 1; i <= n1; i++ )
            {
                Console.Write("Valor #{0}: ", i);
                int s1 = int.Parse(Console.ReadLine());
                soma += s1;
            }
            Console.WriteLine("SOMA: {0}", soma);
        }
    }
}
