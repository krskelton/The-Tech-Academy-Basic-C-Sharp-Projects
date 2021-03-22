using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TwentyOnev2
{
    class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        //the play method plays one hand
        public override void Play()
        {
            //instantiate a dealer
            Dealer = new TwentyOneDealer();
            //reset the players who are in this game, the list of players
            foreach (Player player in Players)
            {
                //for each hand we want the players hand to be blank
                player.Hand = new List<Card>();
                //and we want stay to be false
                player.Stay = false;

            }
            //we also want the dealers hand to be a new hand
            Dealer.Hand = new List<Card>();
            //we also want the dealers stay to be false
            Dealer.Stay = false;
            //and we want a new deck
            Dealer.Deck = new Deck();
            //shuffle the deck
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");
            //get bet for each player
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                //pass their bet to the Bet method to see if they can bet
                bool successfullyBet = player.Bet(bet);
                //if it's false, just return
                if (!successfullyBet)
                {
                    //return tells the program that this method is over and to return to the main program
                    return;
                }
                //we'll create a dictionary object in our game class of all the bets cause it will organize the bet with the player
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    //Console.Write prints to the console but does not automatically create a new line
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    //check for blackjack
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            //becaues the player one they get their bet * 1.5 and they get their bet back
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            //end the round
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                //deal the dealer hand
                Dealer.Deal(Dealer.Hand);
                //check the dealer for blackjack
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        //give the dealer all those bets
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                //ask player hit or stay until they say stay
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        //if they say stay then everything stops in this loop
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    //check if the player busted
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    //if they did give the dealer the bet
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else 
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            //the dealer plays
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            //as long as the dealer doesn't want to stay, give him cards
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    //now we need to give the money to that person - get the list of players where the name equals the name in dictionary
                    //where creates a list but it's just a list of one person
                    //you grab the First() cause it's the only one
                    //entry.Value is what they bet and you times that by 2
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
            }
            //at this point, no one has busted and both the player and the dealer have stayed
            //so we will compare the players hand with the dealers hand and whoever has the highest amount wins
            //loop through each player and compare their hand to the dealers hand
            foreach (Player player in Players)
            {
                //three options:
                //1. Player's hand is greater
                //2. Dealer's hand is greater
                //3. They tie
                //by adding the ? after bool, it means that bool can now have a null value, giving us three options
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins");
                    //give the player his money back
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    //if they win, they get their bet times 2
                    player.Balance += (Bets[player] * 2);
                    //subtract the players amount from the dealers balance
                    Dealer.Balance -= Bets[player];
                }
                else 
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    //add the bet to the dealers balance
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else 
                {
                    player.isActivelyPlaying = false;
                }
            }
            
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
