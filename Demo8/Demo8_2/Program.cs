using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // make a list for all products
            List<Product> products = new List<Product>();

            // create some products
            products.Add(new Product { Name = "Milk", Price = 1.40 });
            products.Add(new Product { Name = "Beer", Price = 2.20 });
            products.Add(new Product { Name = "Booze", Price = 3.20 });
            products.Add(new Product { Name = "Mixer", Price = 4.20 });

            // display all products
            Console.WriteLine("All products in collection:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }

            Console.WriteLine();

            Console.Read();
        }
    }
}
