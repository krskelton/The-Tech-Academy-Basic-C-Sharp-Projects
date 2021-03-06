using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic example
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Casting example below
            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favoriteNumberInteger = Convert.ToInt32(favoriteNumber);
            //int total = favoriteNumberInteger + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char randomLetter = 'A';
            char questionMark = '\u2103';
            //have to add the m to decimal
            decimal moneyInBank = 100.5m;
            double heightInCentimeters = 211.224343;
            //have to have the f for float
            float secondsLeft = 2.63f;

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);



            Console.WriteLine(rainingStatus);
            Console.ReadLine();

        }
    }
}
