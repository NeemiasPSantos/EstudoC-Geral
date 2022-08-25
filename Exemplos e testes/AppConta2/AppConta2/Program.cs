using System;
using System.Globalization;

namespace AppConta2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera depósoto inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine().ToLower());
            ContaBancaria c1 = new ContaBancaria(numero, titular);
           
            if (opcao == 's')
            {
                Console.Write("Informe o valor do depósito inicial: ");
                double dpinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new ContaBancaria(numero, titular, dpinicial);
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: ");
                Console.WriteLine(c1);
            }
            else 
            {
                c1 = new ContaBancaria(numero, titular);
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: ");
                Console.WriteLine(c1);
            }

            Console.WriteLine();
            Console.Write("Informe um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Informe um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(c1);
        }
    }
}
