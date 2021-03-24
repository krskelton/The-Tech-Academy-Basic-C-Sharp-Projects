using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //define a const variable
            const string constantVariable = "Kristin Skelton";
            //write the const variable to the console
            Console.WriteLine("const variable is " + constantVariable);

            //define a var variable
            var varVariable = "This is some text who's data type will be implicity defined.";
            //write the var variable to the console
            Console.WriteLine("var variable is " + varVariable);

            //Create a new person that uses the chained constructor
            Person person = new Person("Kristin");
            //write the person to the console
            Console.WriteLine("I created a person from the Person class by only sending the first name: Kristin. This gives us: " + person.FirstName + " " + person.LastName);

            Console.ReadLine();
        }
    }
}
