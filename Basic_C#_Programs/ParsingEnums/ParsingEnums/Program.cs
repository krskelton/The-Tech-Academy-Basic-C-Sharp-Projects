using System;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user the day of the week
            Console.WriteLine("What is the current day of the week?");
            //try to convert that input into an enum
            try
            {
                //get the user's input
                string userInput = Console.ReadLine();
                //convert the string to an enum
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                //Output the user's input
                Console.WriteLine("You entered: " + day);
            }
            //if there are errors display a response to the user
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
            
        }
        //define enum for days of the week
        public enum DaysOfTheWeek
        { 
            Monday, 
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
