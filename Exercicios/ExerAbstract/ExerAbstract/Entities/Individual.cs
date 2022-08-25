using System.Globalization;

namespace ExerAbstract.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpendituries { get; set; }

        public Individual(string name, double anualIncome, double healthExpendituries ) : base(name, anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
            HealthExpendituries = healthExpendituries;
        }

        public override double Tax()
        {
            double result = 0.0;

            if (AnualIncome >= 20000.0 && HealthExpendituries == 0) 
            {
                result += (AnualIncome * 0.25);
            }

            else if (AnualIncome >= 20000.0 && HealthExpendituries > 0)
            {
                result += (AnualIncome * 0.25) - (HealthExpendituries * 0.50);
            }

            else
            {
                result += (AnualIncome * 0.15) - (HealthExpendituries * 0.50);
            }
            return result;
        }
        public override string Tag()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
