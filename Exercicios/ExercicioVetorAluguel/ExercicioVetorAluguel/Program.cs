using System;

namespace ExercicioVetorAluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Cliente[] v = new Cliente[10];

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Aluguel #{0}", i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                v[quarto] = new Cliente(nome, email);
            }

            Console.WriteLine(" Quartos ocupados: ");
            for (int i = 0; i < 10; i++) 
            {
                if (v[i] != null) 
                {
                    Console.WriteLine(i + " : " + v[i]);
                }
            }
        }
    }
}
