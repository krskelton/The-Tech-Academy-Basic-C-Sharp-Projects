using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new Number object and assign a value to Amount
            Number number = new Number();
            number.Amount = 10.50m;
            //Print the amount
            Console.WriteLine(number.Amount);

            Console.ReadLine();
        }
    }
}
