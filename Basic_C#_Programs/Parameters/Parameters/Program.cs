using System;
using System.Collections.Generic;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an employee list with string data type
            Employee<string> stringThings = new Employee<string>();
            stringThings.Things = new List<string>();
            stringThings.Things.Add("thing1");
            stringThings.Things.Add("thing2");
            stringThings.Things.Add("Dr. Seuss");

            //create an employee list with int data type
            Employee<int> intThings = new Employee<int>();
            intThings.Things = new List<int>();
            intThings.Things.Add(1);
            intThings.Things.Add(2);
            intThings.Things.Add(3);

            //print items
            foreach (string thing in stringThings.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in intThings.Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
