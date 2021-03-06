using System;

namespace StudentReport
{
    class Program
    {
        static void Main()
        {
            //print titles
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            
            //Ask name and store name as a string
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            //Ask course and store as a string
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            
            //Ask page number and convert the string that is returned from the console into an integer
            Console.WriteLine("What page number are you on?");
            string courseNum = Console.ReadLine();
            int courseNumInt = Convert.ToInt32(courseNum);
            
            //Ask if the user needs help and convert the string response to boolean value
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string helpResponse = Console.ReadLine();
            bool helpResponseBool = Convert.ToBoolean(helpResponse);
            
            //Ask about their experiences and save response as a string
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            
            //Ask about feedback and save response as a string
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            
            //Ask number of hours they studied and convert the string response to an integer
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursInt = Convert.ToInt32(hours);

            //print thank you message
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            //add readline so the program pauses and the user can read the above message
            Console.ReadLine();

        }
    }
}
