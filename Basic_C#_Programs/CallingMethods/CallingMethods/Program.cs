using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new MathOperations object
            MathOperations math = new MathOperations();
            Console.WriteLine("What number would you like to perform some math operations on?");
            //save response as an integer
            int response = Convert.ToInt32(Console.ReadLine());

            //Call each math operation, passing them the user's reponse
            Console.WriteLine("When I add 1 to " + response + ", I get: " + math.AddInt(response));
            Console.WriteLine("When I multiply " + response + " by itself, I get: " + math.MultiplyInt(response));
            Console.WriteLine("When I divide " + response + " by 2, I get: " + math.DivideInt(response));

        }

        private static void AddInt(int response)
        {
            throw new NotImplementedException();
        }
    }
}
