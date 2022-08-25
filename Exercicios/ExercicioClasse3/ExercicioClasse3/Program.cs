using System;
using System.Globalization;

namespace ExercicioClasse3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno pessoa = new Aluno();
            Console.Write("Informe o nome do Aluno(a): ");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do Aluno(a): ");
            pessoa.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = pessoa.Media();

            if (pessoa.SituaçãoAluno())
            {
                Console.WriteLine("{0}", pessoa);
                Console.WriteLine("Aprovado");
            }
            else 
            {
                Console.WriteLine("{0}", pessoa);
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram {0} pontos", pessoa.Restante().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
