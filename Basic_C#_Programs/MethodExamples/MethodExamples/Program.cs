using System;

namespace MethodExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate a MethodExamples object
            MethodExamples example = new MethodExamples();
            //Output the result of calling the first MathOperation method
            Console.WriteLine("When I add 2 to the integer 2, I get: " + example.MathOperation(2));
            //Output result of calling the second MathOperation method
            Console.WriteLine("When I multiply the decimal 2.5 by 2.5, I get: " + example.MathOperation(2.5m) + ", because I've returned the value as an integer");
            //Output results of calling the third MathOperation method
            Console.WriteLine("When I divide the string 4 by 2, I get: " + example.MathOperation("4") + ", because I changed it to an integer.");
        }
    }
}