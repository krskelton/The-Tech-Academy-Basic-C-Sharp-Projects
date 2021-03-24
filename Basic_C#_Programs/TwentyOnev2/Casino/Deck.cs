using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            //loop through the face loop
            for (int i = 0; i < 13; i++)
            {
                //loop through each suit
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    //we are casting to Face j
                    card.Face = (Face)i;
                    //cast i to Suit
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
        //The times parameter here is optional because it has a default value. 
        //So if someone doesn't pass it when the method is called, it still has a value
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
