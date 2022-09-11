using System;
using System.Collections.Generic;
using ProjetoPM.Entities.Enum;

namespace ProjetoPM.Entities
{
    internal class Ocorrencias
    {
        public int Telefone { get; set; }
        public string Nome { get; set; }
        public Cidades Cidade { get; set; }
        public string Endereço { get; set; }
        public int Numero { get; set; }

    }
}
