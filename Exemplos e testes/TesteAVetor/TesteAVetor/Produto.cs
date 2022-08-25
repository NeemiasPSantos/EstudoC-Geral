using System;
using System.Globalization;

namespace TesteAVetor
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco) 
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return "Produto: " + Nome + ", preço: R$" + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
