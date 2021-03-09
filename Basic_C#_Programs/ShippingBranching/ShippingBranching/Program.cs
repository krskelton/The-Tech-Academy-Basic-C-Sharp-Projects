using System;

namespace ShippingBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display title message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Prompt user for the weight
            Console.WriteLine("Package Weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            //If weight is greater than 50, print too heavy message
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            //Else get the width, height and length from user
            else {
                Console.WriteLine("Package Width:");
                double width = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Package Height:");
                double height = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Package Length:");
                double length = Convert.ToDouble(Console.ReadLine());
                
                //If the width, height or length are greater than 50, return the too big message
                if (width > 50 || height > 50 || length > 50) {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                } 
                //Else calculate the quote
                else {
                    double quote = (height * width * length) * weight / 100;
                    //Display the quote with amount formatted
                    Console.WriteLine("Your estimated total for shipping this package is: $" + String.Format("{0:n}", quote));
                }
            }
            Console.ReadLine();
        }
    }
}