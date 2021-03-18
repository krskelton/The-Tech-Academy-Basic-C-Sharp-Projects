using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TwentyOnev2
{
    public class Dealer
    {
        public string Name { get; set; }
        //We could think about removing the below one and have the Dealer class inherit from the Deck class 
        //BUT inheritance is an is a relationship, not a has a relationship.
        //So a dealer has a Deck, it is not a Deck
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            //First is a method available to a list that gets the first item in the list
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            //remove it from the deck
            Deck.Cards.RemoveAt(0);
        }
    }
}
