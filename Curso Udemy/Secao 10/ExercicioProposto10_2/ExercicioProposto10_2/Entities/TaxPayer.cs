namespace ExercicioProposto10_2.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncame { get; set; }

        protected TaxPayer()
        {
        }

        protected TaxPayer(string name, double anualIncame)
        {
            Name = name;
            AnualIncame = anualIncame;
        }

        public abstract double Tax();
    }
}
