namespace ExercicioProposto10_2.Entities
{
     class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base (name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(AnualIncame < 20000.00)
            {
                return (AnualIncame * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnualIncame * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
