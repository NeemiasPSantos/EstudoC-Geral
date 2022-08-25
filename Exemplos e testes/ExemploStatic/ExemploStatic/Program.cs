using System;
using System.Globalization;


namespace ExemploStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno pessoa = new Aluno();
            Console.WriteLine("Informe o nome do Aluno: ");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Informe as três notas do aluno: ");
            Aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = Aluno.ResultadoMedia();

            if (pessoa.Aprovado())
            {
                Console.WriteLine("Parabens!!!");
                Console.WriteLine(pessoa);
            }
            else 
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine(pessoa);
            }



        }
    }
}
