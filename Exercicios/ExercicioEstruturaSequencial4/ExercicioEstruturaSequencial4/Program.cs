using System;
using System.Globalization;

namespace ExercicioEstruturaSequencial4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o numero do funcionario: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Qual é o numero de horas trabalhadas? ");
            int horat = int.Parse(Console.ReadLine());
            Console.Write("Diga qual é o valor U$ ganho por hora: ");
            double valorPorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salario = horat * valorPorHora;

            Console.WriteLine();
            Console.WriteLine("NUMBER: {0}", numero);
            Console.WriteLine("SALARY: {0}", salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
