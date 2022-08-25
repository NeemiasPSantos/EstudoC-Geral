using System;
using System.Globalization;

namespace ExercicioClasse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario pessoa = new Funcionario();
            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Sálario bruto: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            pessoa.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionário: {0}", pessoa);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o sálario: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.AumentarSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: {0}", pessoa);
        }
    }
}
