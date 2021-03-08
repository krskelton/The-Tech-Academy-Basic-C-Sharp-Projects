using System;

namespace CalculateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //multiple the user's input by 50 and print the value
            Console.WriteLine("Please enter a number to multiply by 50:");
            int multiply = Convert.ToInt32(Console.ReadLine()) * 50;
            Console.WriteLine(multiply);

            //add 25 to the user's input and print the value
            Console.WriteLine("Please enter a number to add 25 to:");
            int addition = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine(addition);

            //divide the user's input by 12.5. Result needs to allow for decimal places so I used a double.
            Console.WriteLine("Please enter a number to divide 12.5 by:");
            double division = Convert.ToDouble(Console.ReadLine()) / 12.5;
            Console.WriteLine(division);

            //compare the user's input to 50 to see if it's greater. Print true or false.
            Console.WriteLine("Please enter a whole number to see if it's greater than 50:");
            bool greaterThan = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine(greaterThan);

            //Find the remainder of a number divided by 7 and print the value
            Console.WriteLine("Enter a number to find the remainder when it's divided by 7:");
            int remainder = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine(remainder);
        }
    }
}
