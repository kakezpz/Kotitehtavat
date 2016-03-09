using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle sportscar = new Vehicle();
            sportscar.Name = "Audi";
            sportscar.Speed = 150;
            sportscar.Tyres = 4;
            sportscar.PrintData();
            sportscar.Speed = 250;
            Console.WriteLine(sportscar.ToString());

            Vehicle car = new Vehicle();
            car.Name = "Lada";
            car.Speed = 50;
            car.Tyres = 4;
            car.PrintData();
            car.Speed = 100;
            Console.WriteLine(car.ToString());

            Console.ReadLine();
        }
    }
}
