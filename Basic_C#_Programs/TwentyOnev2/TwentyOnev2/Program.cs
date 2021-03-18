using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //below demonstrates polymorphism
            //if you were creating a bunch of games you would want them all to be the same type so you use the parent class
            //the ability of a class to morph into it's inheriting class
            Game game = new TwentyOneGame();
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine();
            Deck deck = new Deck();
            deck.Shuffle();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        
    }
}

