using System;
using System.Globalization;

namespace ExercicioStatic
{
    class Conversor
    {
        public static double Cotacao;
        public static double Dinheiro;
      
        public static double ConversorDeMoeda()
        {
            return (Cotacao * Dinheiro / 100 * 6) + (Cotacao * Dinheiro);
        }

        public override string ToString()
        {
            return "Valor a se pago em reais = " 
                + ConversorDeMoeda().ToString("F2", CultureInfo.InvariantCulture);
        }
    }


}
