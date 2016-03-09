using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new invoice
            Invoice invoice = new Invoice();

            // add invoice data
            invoice.Customer = "Simo Jooseppi";
            invoice.Items.Add(new InvoiceItem("Beer", 1.75, "Poron kusta", 1));
            invoice.Items.Add(new InvoiceItem("Booze", 5.25, "Suomi viinaa", 1));
            invoice.Items.Add(new InvoiceItem("Mixer", 2.50, "Sweppersiä", 2));

            // print invoice
            invoice.PrintInvoice();

            // wait a key press...
            Console.ReadLine();
        }
    }
}
