using System.Globalization;

namespace Course.Entities
{
    class Product
    {
        string Name { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalValue(double Price, int Quantity)
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Name + "," + TotalValue(Price, Quantity).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
