using System;
using System.Globalization;

namespace ExercicioContaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1;
            Console.Write("Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Informe o Titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char questao = char.Parse(Console.ReadLine());

            if (questao == 's' || questao == 'S')
            {
                c1 = new ContaBancaria(nome, numero);
                Console.WriteLine("Informe o valor do deposito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1.Saldo = deposito;
                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(c1);
            }
            else 
            {
                c1 = new ContaBancaria(nome, numero);
                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(c1);
            }

            Console.WriteLine();
            Console.Write("Informe um valor para deposito: ");
            double dpt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(dpt);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(c1);
            
            Console.WriteLine();
            Console.Write("Informa o valor do saque: ");
            dpt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(dpt);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(c1);

        }
    }
}
