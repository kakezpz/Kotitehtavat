using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsCard graphicscard = new GraphicsCard();
            graphicscard.Name = "GTX 980";
            graphicscard.GPU = "6000 MHz";
            graphicscard.VideoRAM = "4212 GB";

            graphicscard.PrintData();



        }
    }
}
