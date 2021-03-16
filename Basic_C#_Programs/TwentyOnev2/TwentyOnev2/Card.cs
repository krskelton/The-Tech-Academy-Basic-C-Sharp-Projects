using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOnev2
{
    public class Card
    {
        //constructor - always the name of the class
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
