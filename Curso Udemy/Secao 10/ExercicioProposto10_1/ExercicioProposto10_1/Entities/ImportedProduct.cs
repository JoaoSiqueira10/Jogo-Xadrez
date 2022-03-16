using System.Globalization;


namespace ExercicioProposto10_1.Entities
{
    class ImportedProduct : Product
    {
        public double CustmomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double custmomsFee) : base(name, price)
        {
            CustmomsFee = custmomsFee;
        }

        public double TotalPrice()
        {
            return Price + CustmomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + "(Customs fee: $ " + CustmomsFee.ToString("F2",CultureInfo.InvariantCulture) + ")";
        }
    }
}
