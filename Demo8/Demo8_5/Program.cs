using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.6, 3.8, 4.9, 5.3, 6.2, 666 };
            Console.WriteLine("Sum = {0:F2}", ArrayCalcs.Sum(array));
            Console.WriteLine("Average = {0:F2}", ArrayCalcs.Average(array));
            Console.WriteLine("Min = {0:F2}", ArrayCalcs.Min(array));
            Console.WriteLine("Max = {0:F2}", ArrayCalcs.Max(array));

            Console.WriteLine("Press enter key to continue...");
            Console.Read();
        }
    }
}
