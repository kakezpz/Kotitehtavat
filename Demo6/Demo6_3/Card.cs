using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_3
{
    class Card
    {
        public string Suit { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return "Suit: " + Suit + " Number: " + Number;
        }
    }
}
