namespace ExerAbstract.Entities
{
    abstract internal class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        abstract public double Tax();

        abstract public string Tag();
    }
}
