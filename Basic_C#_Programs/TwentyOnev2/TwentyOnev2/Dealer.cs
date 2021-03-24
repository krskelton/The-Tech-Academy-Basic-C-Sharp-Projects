using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

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

            //log each card to a file
            string card = string.Format(Deck.Cards.First().ToString() + "\n");

            Console.WriteLine(card);
            //you are dealing with unmanaged code so you need to make sure things are disposed of.
            using (StreamWriter file = new StreamWriter(@"C:\Users\kskel\html-css-projects\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\TwentyOnev2\logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }

            //remove it from the deck
            Deck.Cards.RemoveAt(0);
        }
    }
}
