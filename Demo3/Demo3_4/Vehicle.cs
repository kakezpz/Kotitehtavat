using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Name: {0} Speed: {1} Tyres: {2}", Name, Speed, Tyres);
        }

        public override string ToString()
        {
            return "Name: " + Name + " Speed: " + Speed + " Tyres: " + Tyres;
        }
    }

}
