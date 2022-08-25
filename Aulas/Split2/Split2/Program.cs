using System;
using System.Globalization;

namespace Split2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe com o nome completo: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("Quantos quartos a casa tem? ");
            int q1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite com o preço do produto: ");
            double p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o seu ultimo nome, idade e altura (na mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2],CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine();

            Console.WriteLine(n1);
            Console.WriteLine(q1);
            Console.WriteLine(p1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
