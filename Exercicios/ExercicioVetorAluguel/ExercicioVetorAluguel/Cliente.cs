using System;

namespace ExercicioVetorAluguel
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;

        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
