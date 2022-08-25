using System;
using System.Globalization; 

namespace ExemploStatic
{
    class Aluno
    {
        public string Nome;
        public static double Nota1, Nota2, Nota3;

        public static double ResultadoMedia() 
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public bool Aprovado() 
        {
            if (ResultadoMedia() >= 35)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Media do aluno "
                + Nome
                + " é: "
                + ResultadoMedia().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
