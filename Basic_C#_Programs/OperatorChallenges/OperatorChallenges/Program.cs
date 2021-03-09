using System;

namespace OperatorChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            //Demostrate greater than operator
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 20)
            {
                Console.WriteLine("Congrats! You can drink!");
            }
            else {
                Console.WriteLine("Sorry, you can't have a drink!");
            }

            //Demostrate less than or equal operator
            if (age <= 17)
            {
                Console.WriteLine("You are not an adult yet!");
            }
            else {
                Console.WriteLine("You are an adult!");
            }

            //Demonstrate the ternary operator
            int num1 = 10;
            int num2 = 25;
            string result = num1 < num2 ? "num1 is less than num2" : "num1 is greater than num2";
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
