using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array of strings
            string[] stringArray = { "Amazing", "Fabulous", "The BEST" };
            //ask the user to select an index
            Console.WriteLine("Choose a number 1 - " + stringArray.Length + ":");
            //make sure the user's input is a number, if not catch the type exception
            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine());
                //Try to print the user's choice. 
                //If it throws an exception, it is not a number in the array. Catch this.
                try
                {
                    Console.WriteLine(stringArray[userNum-1]);
                }
                //The user did not enter a number within the range provided
                catch (Exception) {
                    Console.WriteLine("You did not enter a number 1-" + stringArray.Length + ".");
                }
            }
            //The user did not enter a string that could be converted to an int
            catch (Exception) {
                Console.WriteLine("You did not enter a number.");
            }


            //create an array of integers
            int[] intArray = { 200, 400, 10000, 200000};
            //ask the user to select an index
            Console.WriteLine("Choose a number 1 - " + intArray.Length + ":");
            //make sure the user's input is a number, if not catch the type exception
            try
            {
                int userNum2 = Convert.ToInt32(Console.ReadLine());
                //Try to print the user's choice. 
                //If it throws an exception, it is not a number in the array. Catch this.
                try
                {
                    Console.WriteLine(intArray[userNum2-1]);
                }
                //The user did not enter a number within the range provided
                catch (Exception)
                {
                    Console.WriteLine("You did not enter a number 1-" + intArray.Length + ".");
                }
            }
            //The user did not enter a string that could be converted to an int
            catch (Exception)
            {
                Console.WriteLine("You did not enter a number.");
            }


            //create a list of strings
            List<string> stringList = new List<string>();
            stringList.Add("Cool");
            stringList.Add("Greatest");
            //ask the user to select an index
            Console.WriteLine("Choose a number 1 - " + stringList.Count + ":");
            //make sure the user's input is a number, if not catch the type exception
            try
            {
                int userNum3 = Convert.ToInt32(Console.ReadLine());
                //Try to print the user's choice. 
                //If it throws an exception, it is not a number in the array. Catch this.
                try
                {
                    Console.WriteLine(stringList[userNum3 - 1]);
                }
                //The user did not enter a number within the range provided
                catch (Exception)
                {
                    Console.WriteLine("You did not enter a number 1-" + stringList.Count + ".");
                }
            }
            //The user did not enter a string that could be converted to an int
            catch (Exception)
            {
                Console.WriteLine("You did not enter a number.");
            }

        }
    }
}
