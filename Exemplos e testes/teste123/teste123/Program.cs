using System;
using System.Globalization;

namespace teste123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome, 1º nota e 2º nota do aluno: ");
            string[] aluno = Console.ReadLine().Split(' ');
            string nome = aluno[0];
            double nota1 = double.Parse(aluno[1], CultureInfo.InvariantCulture);
            double nota2 = double.Parse(aluno[2], CultureInfo.InvariantCulture);

            Console.WriteLine();

            double media = (nota1 + nota2) / 2;

            if (media >= 5.0)
            {
                Console.WriteLine("Parabéns o aluno {0} foi aprovado, média do aluno foi: {1}", nome, media.ToString("F2", CultureInfo.InvariantCulture));
            }
            else 
            {
                Console.WriteLine("Que pena o aluno {0} foi reprovado, média do aluno foi: {1}", nome, media.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
