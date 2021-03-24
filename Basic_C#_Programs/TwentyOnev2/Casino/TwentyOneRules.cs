using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Casino.TwentyOne
{
    public class TwentyOneRules
    {
        //create a private dictionary of card values
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            //ace can be worth 10 or 1 but we can't give it two values, so we'll have to add that into our logic later
            [Face.Ace] = 1
        };
        //Method to determine what the ace will equal
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            //this method will return all the possible values for a hand
            //see how many aces we have
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            //number of possible results
            int[] result = new int[aceCount + 1];
            //get the minimum value
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            //if there are no aces or only one ace, then the result is the value
            if (result.Length == 1)
            {
                return result;
            }
            //for each ace we make a separate value and add 10 to it
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValue = GetAllPossibleHandValues(Hand);
            //get the maximum possible value
            int value = possibleValue.Max();
            //check if it equals 21
            if (value == 21) return true;
            else return false;
        }

        //determine if the player busted
        public static bool IsBusted(List<Card> Hand)
        {
            //if the minimum values bust then all the values bust
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        //method to determine if the dealer should stay
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValue = GetAllPossibleHandValues(Hand);
            //above 16 and below 22, the dealer has to stay
            foreach (int value in possibleHandValue)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        //method to compare the player's hand to the dealer's hand to see who has the higher number
        //the return type is bool? so that it can return a null
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            //we have to find the highest value that is less than 22
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
