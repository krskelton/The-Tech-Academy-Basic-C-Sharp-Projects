using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOnev2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
            //Get user name
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name");
            string playerName = Console.ReadLine();
            //Get amount of money 
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            //Ask if they want to join a game
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            //convert answer to lowercase so there are fewer values you need to account for
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //if they want to play, create a new player object and intialize them
                Player player = new Player(playerName, bank);
                
                //we use Game here so it exposes those overloaded operators
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                
                //while loop checks if the player wants to keep playing and still has money to play
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    //call the play method
                    game.Play();
                }
                
                //after the player exists the while loop we subtract them
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
    }
}

