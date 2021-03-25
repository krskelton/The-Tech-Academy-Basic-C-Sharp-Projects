using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask use for their age
            Console.WriteLine("Enter your age:");
            //try to change the entry into an integer
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new InvalidAgeException();
                }
                //get the current year and subtract the user's age
                DateTime currentDate = DateTime.Now;
                int year = currentDate.Year;
                //get their birth year by subtracting the age from the current year. 
                //Note: without the month and year they were born, this year could be off.
                int birthYear = year - age;
                Console.WriteLine(birthYear);
                Console.ReadLine();
            }
            catch (InvalidAgeException)
            {
                Console.WriteLine("Please do not enter a zero or negative number");
                Console.ReadLine();
            }
            //catch errors
            catch (Exception)
            {
                Console.WriteLine("I'm sorry an error has occurred. Please contact your administrator");
                Console.ReadLine();
            }
            
            
        }
    }
}
