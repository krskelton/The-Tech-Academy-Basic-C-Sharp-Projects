using System;
using System.Collections.Generic;

namespace IntegerDivisionErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //new integer list
            List<int> integerList = new List<int>();
            integerList.Add(400);
            integerList.Add(800);
            integerList.Add(1400);

            //Get number from the user
            Console.WriteLine("Enter a number:");
            Console.WriteLine("(The number you enter will be divided by our list!)");
            try
            {
                //try to convert the user's response into an integer
                int userNum = Convert.ToInt32(Console.ReadLine());

                //Iterate through list and divide each number by the number the user enters
                foreach (int number in integerList)
                {
                    Console.WriteLine(number + " / " + userNum + " = " + number / userNum);
                }
            }
            //catch the error that they typed in something other than a number
            catch (System.FormatException ex)
            {
                Console.WriteLine("You can only divide by whole numbers.");
            }
            //catch the error that they used a 0 to divide by
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            //print off any other errors
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Display a thank you message
            finally
            {
                Console.WriteLine("Thank you for playing.");
            }
            //Type good bye to note that the try catch block has ended
            Console.WriteLine("Good bye.");
            Console.ReadLine();
        }
    }
}
