using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Card
    {
        //constructor - it's always the name of the class
        public Card() 
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
