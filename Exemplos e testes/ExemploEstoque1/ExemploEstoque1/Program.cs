using System;
using System.Globalization;

namespace ExemploEstoque1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            x.Quantidade = int.Parse(Console.ReadLine());

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
