using System;
using System.Globalization;

namespace ExercicioClasse3
{
    class Aluno
    {
        public string Nome;
        public double A, B, C;


        public double Media()
        {
            return A + B + C;
        }
        public double Restante()
        {
            return 60.0 - Media();
        }
        public bool SituaçãoAluno()
        {

            if (Restante() >= 60.0)
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
            return "Nota Final = " + Media().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
