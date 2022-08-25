using System;

namespace teste321
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, n1;
            int senha, s1;

            Console.WriteLine("Crie o login e senha(escreva na mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');
            nome = vetor[0];
            senha = int.Parse(vetor[1]);

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Informe o login e senha para entrar no sistema: ");
                
                Console.WriteLine();
                Console.Write("Usuario: ");
                n1 = Console.ReadLine();
                Console.Write("Senha: ");
                s1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int i2 = 0; i2++;

                if (n1 == nome && s1 == senha)
                {
                    Console.WriteLine("Login feito com sucesso!!!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Falha ao tentar logar, tente novamente.");
                    Console.WriteLine("{0} Tentativas feitas de logar", i2);
                }
            }
        }
    }
}
