namespace TaxCalculation.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base (name, anualIncome)
        {
        }

        public override double CalculateTaxes()
        {
            if(AnualIncome < 2000)
            {
                if(HealthExpenditures != 0)
                {
                    return ((AnualIncome * (15/100)) - (HealthExpenditures * (50/100)));
                } 
                else
                {
                    return (AnualIncome * (15 / 100));
                }
            } 
            else
            {
                if (HealthExpenditures != 0)
                {
                    return ((AnualIncome * (25 / 100)) - (HealthExpenditures * (50 / 100)));
                }
                else
                {
                    return (AnualIncome * (25 / 100));
                }
            }
        }
    }
}
