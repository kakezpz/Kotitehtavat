using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create CD object
            CD cd = new CD();
            cd.Artist = "Insomnium";
            cd.Name = "Above The Weeping World";
            cd.Genre = "Melodeath-metal";
            cd.Price = 19.90;
            cd.AddSong(new Song { Name = "The Gale", LengthInSeconds = 600 });
            cd.AddSong(new Song { Name = "Mortal Share", LengthInSeconds = 600 });
            cd.AddSong(new Song { Name = "Drawn to Black", LengthInSeconds = 600 });
            cd.AddSong(new Song { Name = "Change of Heart", LengthInSeconds = 600 });
            cd.AddSong(new Song { Name = "At the Gates of Sleep", LengthInSeconds = 600 });
            cd.AddSong(new Song { Name = "The Killjoy", LengthInSeconds = 600 });
            cd.AddSong(new Song { Name = "Last Statement", LengthInSeconds = 600 });
            cd.AddSong(new Song { Name = "Devoid of Caring", LengthInSeconds = 600 });
            cd.AddSong(new Song { Name = "In the Groves of Death", LengthInSeconds = 600 });

            Console.WriteLine(cd.ToString());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
