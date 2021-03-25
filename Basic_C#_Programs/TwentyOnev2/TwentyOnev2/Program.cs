using System;
using Casino;
using Casino.TwentyOne;
using System.IO;

namespace TwentyOnev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user name
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }
            //Get amount of money 
            //Console.WriteLine("How much money did you bring today?");
            //int bank = Convert.ToInt32(Console.ReadLine());
            //Ask if they want to join a game
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            //convert answer to lowercase so there are fewer values you need to account for
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //if they want to play, create a new player object and intialize them
                Player player = new Player(playerName, bank);
                //create a guid
                player.Id = Guid.NewGuid();

                using (StreamWriter file = new StreamWriter(@"C:\Users\kskel\html-css-projects\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\TwentyOnev2\logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }

                //we use Game here so it exposes those overloaded operators
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security, kick this person out.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
                
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

