using System;

namespace NotOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a cat? Please respond \"true\" or \"false\".");
            bool isCat = Convert.ToBoolean(Console.ReadLine());
            if (isCat != true)
            {
                Console.WriteLine("Cats are cool. You should be a cat!");
            }
            else {
                Console.WriteLine("I love that you are a cat!");
            }
            Console.ReadLine();
        }
    }
}
