using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "Mein Kampf";
            book.ISBN = "666-666-666";
            Console.WriteLine("Book : " + book.Name + " " + book.ISBN);

            CD cd = new CD();
            cd.Artist = "Wagner";
            cd.Name = "The Best of Wagner";
            Console.WriteLine("CD : " + cd.Artist + " " + cd.Name);

            DVD dvd = new DVD();
            dvd.Name = "Downfall";
            dvd.Format = "MP4";
            Console.WriteLine("Name : " + dvd.Name + " " + dvd.Format);

            Console.ReadLine();
        }
    }
}
