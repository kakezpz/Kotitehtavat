using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8_1
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Dice was thrown once and the value is: " + Dice.Throw());

            Console.Write("How many times do you want to throw the dice:  ");
            string line = Console.ReadLine();
            int times = int.Parse(line);

            double sum = 0;
            int value;
            int[] values = new int[7]; 
            for (int i = 1; i <= times; i++)
            {
                value = Dice.Throw();
                sum += value;
                values[value]++;
            }

            Console.WriteLine();
            Console.WriteLine("Dice was thrown {0} times", times);
            Console.WriteLine("-the average is {0}", sum / times);
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("- {0} count is {1}", i, values[i]);
            }

            Console.WriteLine("Press enter key to continue...");
            Console.Read();

        }
    }
}
