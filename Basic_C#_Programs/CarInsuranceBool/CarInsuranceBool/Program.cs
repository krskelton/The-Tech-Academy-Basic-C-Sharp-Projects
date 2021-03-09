using System;

namespace CarInsuranceBool
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determine age of user
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //Determine if user had a DUI
            Console.WriteLine("Have you ever had a DUI? Please answer either \"true\" or \"false\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            //Determine if user has any speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            //Determine if the user is eligible for car insurance
            //Age must be over 15
            //No DUIs
            //No more than 3 speeding tickets
            bool isEligible = age > 15 && dui == false && tickets <= 3;
            Console.WriteLine("Qualified?\n" + isEligible);
            Console.ReadLine();
        }
    }
}
