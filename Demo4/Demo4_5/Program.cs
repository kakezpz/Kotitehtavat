using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates Radio object
            Radio radio = new Radio();
            // Turns radio on and sets volume and frequency
            radio.IsOpen = true;
            radio.Volume = 5;
            radio.Frequency = 3000.00;
            Console.WriteLine(radio.ToString());

            // tries an invalid volume setting
            radio.Volume = 100;
            Console.WriteLine(radio.ToString());

            // tries an invalid frequency setting
            radio.Frequency = 100000.00;
            Console.WriteLine(radio.ToString());

            // turns radio off and sets volume
            radio.IsOpen = false;
            radio.Volume = 8;
            Console.WriteLine(radio.ToString());

            // tries frequency
            radio.IsOpen = true;
            radio.Frequency = 9000.00;
            Console.WriteLine(radio.ToString());

            Console.ReadLine();
        }
    }
}
