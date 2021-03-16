using System;

namespace MethodsWithOptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            OptionalParameters example = new OptionalParameters();
            //ask the user to input two numbers
            Console.WriteLine("Enter a number: ");
            //try to convert the user's input to an integer, it will convert or throw a format exception
            try
            {
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number (optional): ");
                //If the user enters a second number it will be able to convert it to a string
                //if they don't it will throw a formatexception 
                try
                {
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Adding the two numbers together gives us: " + example.optional(number1, number2));
                }
                //Tell the user they did not enter an integer for the second number 
                //and process it with just the first number they entered
                catch (FormatException ex)
                {
                    Console.WriteLine("You did not enter a second number or did not enter it in the correct format.");
                    Console.WriteLine("So, I will add just your first number with mine. This gives us: " + example.optional(number1));
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please start over and only enter whole numbers.");
            }
            
        }
    }
}
