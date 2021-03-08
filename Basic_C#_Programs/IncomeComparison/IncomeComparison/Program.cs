using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print heading
            Console.WriteLine("Anonymous Income Comparison Program");
            
            //Ask the user for input about Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            //Save hourly rate and hours worked to doubles so decimal places can be added
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            double hoursWorked1 = Convert.ToDouble(Console.ReadLine());
            //Calculate salary of Person 1
            double salary1 = (hourlyRate1 * hoursWorked1) * 52;

            //Ask the user for input about Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            //Save hourly rate and hours worked to doubles so decimal places can be added
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            double hoursWorked2 = Convert.ToDouble(Console.ReadLine());
            //Calculate salary of Person 2
            double salary2 = (hourlyRate2 * hoursWorked2) * 52;

            //Display the annual salaries of both people. Format the response so it adds commas and a decimal point
            Console.WriteLine("Annual Salary of Person 1:\n" + "$" + String.Format("{0:n}", salary1));
            Console.WriteLine("Annual Salary of Person 2:\n" + "$" + String.Format("{0:n}", salary2));

            //Determine if Person 1 makes more money than Person 2
            bool p1MoreMoney = salary1 > salary2;
            //Print result
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1MoreMoney);
            Console.ReadLine();
        }
    }
}
