using System;
using System.Collections.Generic;

namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1 - create an array, ask the user for input and add it to each item in the array
            Console.WriteLine("PART 1");
            string[] names = { "Kristin", "Cali", "Bailey", "Seth" };
            Console.WriteLine("Enter a adjective:");
            string userResponse = Console.ReadLine();

            //iterate through names array
            for (int i = 0; i < names.Length; i++) {
               //Add the userResponse to each string in the names array
                names[i] = names[i] + " is " + userResponse;
            }

            //Iterate through the names array to print the results
            for (int j = 0; j < names.Length; j++) {
                //Print each name in the list
                Console.WriteLine(names[j]);
            }


            //PART 2 - create an infinite loop and then fix it
            Console.WriteLine("\nPART 2");
            bool isTrue = true;

            //Practice with while loops, create an infinite loop and then fix it
            //By asking the user to change the isTrue variable it fixes the infinite loop
            while (isTrue) {
                Console.WriteLine("The infinite loop has been fixed.");
                Console.WriteLine("Do you want to keep going? Answer true or false.");
                isTrue = Convert.ToBoolean(Console.ReadLine());
            }

            //PART 3 - iterate through loops using the < operator and the <= operator
            Console.WriteLine("\nPART 3");
            Console.WriteLine("Can you guess my number?");
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 20;

            //Create a loop where the comparison used to determine whether or not to continue is <
            if (num1 < num2)
            {
                Console.WriteLine("Your number is less than " + num2);
                Console.WriteLine("I will add 1 until it equals " + num2);
                while (num1 < num2)
                {
                    Console.WriteLine(num1 + 1);
                    num1++;
                }
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Your number is equal to " + num2);
            }
            else 
            {
                Console.WriteLine("The number you entered is greater than " + num2);
                Console.WriteLine("I will subtract one until it is equal to" + num2);
                while (num1 > num2) {
                    Console.WriteLine(num1 - 1);
                    num1--;
                }
            }

            //A loop where the comparison operator is <=.
            Console.WriteLine("\nThe next loop will iterate until the example number originally set to 0 equals 10. I will add 2 each iteration.");
            int exampleNum = 0;
            do {
                exampleNum = exampleNum + 2;
                Console.WriteLine("Number + 2: " + exampleNum);
            } while (exampleNum <= 8);

            //PART 4 - create a list of strings and ask the user to guess one of the items
            Console.WriteLine("\nPART 4");
            //Create a list of strings where each item is unique
            List<string> stringList = new List<string>();
            stringList.Add("dog");
            stringList.Add("cat");
            stringList.Add("bunny");

            //Ask the user to guess an item in the list and display the index of the matching text
            Console.WriteLine("Can you guess an animal in the list?");
            string userSearch = Console.ReadLine();

            //Create a list to hold the search results
            List<string> searchResults = new List<string>();

            //iterate through each item in the list
            foreach (string item in stringList) {
                //foreach item check to see if it matches the user input
                if (item.Contains(userSearch))
                {
                    searchResults.Add("A match was found at index: " + stringList.IndexOf(item));
                    break;
                }
                //if not, continue the loop
                else {
                    continue;
                }
            }
            //If there are results in the searchResults list
            if (searchResults.Count >= 1)
            {
                //Iterate through the searchResults list and display the results
                foreach (string response in searchResults)
                {
                    Console.WriteLine(response);
                }
            }
            //if there is nothing in the search results list tell the user that their search wasn't in the list
            else {
                Console.WriteLine("Your search was not in the list.");
            }

            //PART 5 - create a list that has matching strings and check for the user's input like above
            Console.WriteLine("\nPART 5");
            //Create a list of strings where there are two matching items
            List<string> emotionsList = new List<string>();
            emotionsList.Add("happy");
            emotionsList.Add("sad");
            emotionsList.Add("mad");
            emotionsList.Add("happy");

            //Ask the user to guess an item in the list and display the index of the matching text
            Console.WriteLine("What emotion do you feel right now?");
            string userEmotion = Console.ReadLine();

            //Create a list to hold the search results
            List<string> emotionsResults = new List<string>();

            //iterate through each item in the list
            for (int i = 0; i < emotionsList.Count; i++)
            {
                //foreach item check to see if it matches the user input
                if (emotionsList[i] == userEmotion)
                {
                    emotionsResults.Add("A match was found at index: " + i);
                }
                //if not, continue the loop
                else
                {
                    continue;
                }
            }
            //If there are results in the searchResults list
            if (emotionsResults.Count >= 1)
            {
                //Iterate through the searchResults list and display the results
                foreach (string emotionResult in emotionsResults)
                {
                    Console.WriteLine(emotionResult);
                }
            }
            //if there is nothing in the search results list tell the user that their search wasn't in the list
            else
            {
                Console.WriteLine("Your emotion was not in the list.");
            }


            //PART 6 - create a list of strings with two identical strings
            Console.WriteLine("\nPART 6");
            List<string> sameStringList = new List<string>();
            sameStringList.Add("John Smith");
            sameStringList.Add("John Smith");
            sameStringList.Add("Suzie Smith");
            sameStringList.Add("Kristin Skelton");

            //New list to keep up with items that have already been displayed
            List<string> trackResults = new List<string>();

            //Iterate over list
            foreach (string name in sameStringList) {
                //If the name is in the new list, it has already come before, if not, it is new on the list
                if (trackResults.Contains(name))
                {
                    Console.WriteLine(name + " is already in the list!");
                    //Add to list
                    trackResults.Add(name);
                }
                else {
                    Console.WriteLine(name + " has not been in the list yet.");
                    //Add to list
                    trackResults.Add(name);
                }
                
            }
            Console.ReadLine();
        }
    }
}
