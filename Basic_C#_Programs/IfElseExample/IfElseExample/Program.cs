using System;

namespace IfElseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a dog? Please answer \"true\" or \"false\".");
            bool isDog = Convert.ToBoolean(Console.ReadLine());
            if (isDog)
            {
                Console.WriteLine("Woof Woof!");
            }
            else {
                Console.WriteLine("You wouldn't understand if you aren't a dog.");
            }
            Console.ReadLine();
        }
    }
}
