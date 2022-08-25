using System.Globalization;

namespace ExerAbstract.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees): base(name, anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double result = 0.0;
            if(NumberOfEmployees > 10)
            {
                result += AnualIncome * 0.14;
            }
            else
            {
                result += AnualIncome * 0.16;
            }
            return result;
        }

        public override string Tag()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
