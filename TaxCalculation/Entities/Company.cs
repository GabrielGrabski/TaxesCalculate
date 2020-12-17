namespace TaxCalculation.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployeers { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployeers) : base (name, anualIncome)
        {
            NumberOfEmployeers = numberOfEmployeers;
        }

        public override double CalculateTaxes()
        {
            if(NumberOfEmployeers > 10)
            {
                return AnualIncome * (16 / 100);
            }
            else
            {
                return AnualIncome * (14 / 100);
            }
        }
    }
}
