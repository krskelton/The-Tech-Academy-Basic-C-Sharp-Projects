using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate three strings
            string dog = "Cali";
            string cat = "Bailey";
            string daughter = "Cameron";
            string myFamily = "My family is made up of " + dog + ", " + cat + ", " + "and " + daughter + ".";
            Console.WriteLine(myFamily);

            //Convert string to uppercase
            string boyfriend = "Seth";
            Console.WriteLine("There's also a cute boy named " + boyfriend.ToUpper() + "!");

            //Create a StringBuilder and build a paragraph
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("This is a paragraph about my family. ");
            paragraph.Append("I love them very much! ");
            paragraph.Append("They are the sweetest people and pets on earth. ");
            Console.WriteLine(paragraph);

            Console.ReadLine();
        }
    }
}
