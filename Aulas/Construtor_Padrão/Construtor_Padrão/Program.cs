using System;
using System.Globalization;

namespace Construtor_Padrão
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto x = new Produto(preco, quantidade);
            x.Nome = nome;

            Console.WriteLine("Dados do produto: {0}", x);
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.AdicionarProdutos(qtd);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: {0}", x);
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.RemoverProdutos(qtd);
            Console.WriteLine();



            Console.WriteLine("Dados atualizados: {0}", x);
        }
    }
}
