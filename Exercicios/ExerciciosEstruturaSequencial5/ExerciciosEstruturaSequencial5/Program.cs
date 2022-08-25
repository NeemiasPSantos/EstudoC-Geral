using System;
using System.Globalization;

namespace ExerciciosEstruturaSequencial5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro o codigo, quantidade de peças, e o valor do produto: ");
            string[] vetor1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vetor1[0]);
            int quantidade1 = int.Parse(vetor1[1]);
            double preco1 = double.Parse(vetor1[2], CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Informe o segundo codigo, quantidade de peças, e o valor do produto: ");
            string[] vetor2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vetor2[0]);
            int quantidade2 = int.Parse(vetor2[1]);
            double preco2 = double.Parse(vetor2[2], CultureInfo.InvariantCulture);

            Console.WriteLine();

            double valor1 = quantidade1 * preco1;
            double valor2 = quantidade2 * preco2;
            double aPagar = valor1 + valor2;

            Console.WriteLine("VALOR A PAGAR: R${0}", aPagar.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
