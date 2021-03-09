using System;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number) {
                case 1:
                    Console.WriteLine("You chose one of my numbers!");
                    break;
                case 5:
                    Console.WriteLine("You chose one of my numbers!");
                    break;
                case 10:
                    Console.WriteLine("You chose one of my numbers!");
                    break;
                default:
                    Console.WriteLine("Sorry, you did not choose one of my numbers!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
