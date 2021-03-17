using System;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            VoidMethod example = new VoidMethod();
            //get a number from the user
            Console.WriteLine("Enter a whole number:");
            //try to convert the response to an int
            try
            {
                int userResponse = Convert.ToInt32(Console.ReadLine());
                example.DivideInt(userResponse);
            }
            //catch if the user does not enter an int
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a whole number.");
            }

            //declare variables for output parameters
            int number1, number2;
            //get out values from method
            example.GetValues(out number1, out number2);
            //Write the values to the console
            Console.WriteLine("The first value you entered was: " + number1);
            Console.WriteLine("The second value you entered was: " + number2);

            //call the overloaded method - ask the user what two numbers they want to use
            Console.WriteLine("Enter a whole number to divide: ");
            //try to convert the user's response to an integer
            try
            {
                int usernumber1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a whole number to divide: ");
                try
                {
                    int usernumber2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your first number divided by your second number is: " + usernumber1 / usernumber2);
                }
                catch
                {
                    Console.WriteLine("You did not enter a whole number");
                }
            }
            //catch the format error if it's not an integer
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a whole number.");
            }

            //Demonstrate calling a static class - you do not instantiate a static class like we did above
            Console.WriteLine("5 and 10 are added together with a static class to make: " + StaticClass.AddInt(5, 10));


            Console.ReadLine();
        }
    }
}
