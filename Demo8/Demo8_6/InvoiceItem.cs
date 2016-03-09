using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8_6
{
    public class InvoiceItem
    {
        public string Name { get; }
        public double Price { get; }
        public string Description { get; }
        public int Quantity { get; }
        public double Total => (Price * Quantity);
        public InvoiceItem(string name, double price, string desc, int quantity)
        {
            Name = name;
            Price = price;
            Description = desc;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Name + " " + Price + "e " + Quantity + " pieces " + Total + "e total";
        }
    }
}
