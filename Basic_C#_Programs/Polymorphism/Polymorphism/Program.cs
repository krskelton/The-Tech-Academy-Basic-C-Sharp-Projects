using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //use polymorphism to create an object of type IQuittable
            IQuittable quitProgram = new Employee();
            //Call the quit program
            quitProgram.Quit();

            Console.ReadLine();
        }
    }
}
