using System;
using System.IO;

namespace FileLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a number
            Console.WriteLine("Enter a number: ");
            //store the number they entered - it needs to be a string to write it to the text file but you could convert it and then back to a string if you needed to perform operations on the number
            string number = Console.ReadLine();

            //log that number in a text file
            File.WriteAllText(@"C:\Users\kskel\html-css-projects\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\FileLogging\Logs\log.txt", number);
            //get the text in the text file
            string textFile = File.ReadAllText(@"C:\Users\kskel\html-css-projects\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\FileLogging\Logs\log.txt");
            //print the contents of the text file back to the user
            Console.WriteLine("You entered: " + textFile);
        }
    }
}
