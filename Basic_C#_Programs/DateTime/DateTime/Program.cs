using System;
using System.IO;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the current time and date
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDate);
            //Ask the user for a number
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            //Add the number to the currentDate
            DateTime laterTime = currentDate.AddHours(number);
            //Print the time it will be in x hours, defined by the number the user entered
            Console.WriteLine("In " + number + " hours, it will be: " + laterTime);
        }
    }
}
