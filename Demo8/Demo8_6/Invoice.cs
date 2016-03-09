using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8_6
{
    public class Invoice
    {
        public string Customer { get; set; }
        public double Total => ComputeTotal();
        public int TotalItems => CountTotalItems();
        public List<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();

        private double ComputeTotal()
        {
            double total = 0;
            foreach (InvoiceItem item in Items)
            {
                total += item.Total;
            }
            return total;
        }
        private int CountTotalItems()
        {
            return Items.Count;
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Customer {0}'s invoice:", Customer);
            Console.WriteLine("=================================");
            foreach (InvoiceItem item in Items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("=================================");
            Console.Write("Total : " + Total + " euros");
        }
    }
}
