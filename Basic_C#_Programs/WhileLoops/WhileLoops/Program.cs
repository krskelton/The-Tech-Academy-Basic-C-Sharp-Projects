using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determine if the user owns a pet
            Console.WriteLine("Do you have a pet? Answer \"true\" or \"false\".");
            bool petOwner = Convert.ToBoolean(Console.ReadLine());
            //If the person is a pet owner - ask them their pet's name
            if (petOwner)
            {
                //Ask name and store as name
                Console.WriteLine("Pet's Name:");
                string name = Console.ReadLine();

                //Ask question that will start the while loop
                Console.WriteLine("Do you want to give " + name + " love? Answer \"true\" or \"false\".");
                bool giveLove = Convert.ToBoolean(Console.ReadLine());

                //if giveLove == true, then continue to ask them if they want to give their pet love, 
                //end while loop when giveLove == false
                while (giveLove)
                {
                    Console.WriteLine("I love you, " + name);
                    Console.WriteLine("Do you want to give " + name + " love? Answer \"true\" or \"false\".");
                    giveLove = Convert.ToBoolean(Console.ReadLine());
                }
                //Display message to user once they come out of the while loop
                Console.WriteLine("Poor, " + name);

                //Example of do while loop
                //Give pet a treat until giveTreat == false
                bool giveTreat = true;
                do
                {
                    Console.WriteLine("Here's a treat, " + name + "!");
                    Console.WriteLine("Can " + name + " have another treat? Answer \"true\" or \"false\".");
                    giveTreat = Convert.ToBoolean(Console.ReadLine());
                } while (giveTreat);
                //Display message when user comes out of while loop
                Console.WriteLine("Poor, " + name);
            }
            //if petOwner == false, show message
            else {
                Console.WriteLine("You should get a pet!");
            }
            Console.ReadLine();
        }
    }
}
