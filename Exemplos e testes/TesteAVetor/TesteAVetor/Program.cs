using System;
using System.Globalization;

namespace TesteAVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho de posições da lista: ");
            int n = int.Parse(Console.ReadLine());
            Produto[] vetor = new Produto[n];

            for (int i = 0; i < n; i++) 
            {
                Console.Write("Informe o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Produto(nome, preco);
            }

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
