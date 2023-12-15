
using System.Globalization;

namespace Produtos.Entities
{
    internal class UsedProduct : Product
    {
        public string ManufactureDate {  get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, string manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (Usado) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data de fabricação: " + ManufactureDate + " )"; ;
        }
    }
}
