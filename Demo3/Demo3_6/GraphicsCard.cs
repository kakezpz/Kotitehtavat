using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_6
{
    class GraphicsCard
    {
        public string Name { get; set; }
        public string GPU { get; set; }
        public string VideoRAM { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Name: {0} \nGPU: {1} \nVideo RAM: {2}", Name, GPU, VideoRAM);
        }
    }
}
