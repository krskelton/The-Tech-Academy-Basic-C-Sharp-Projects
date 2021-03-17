using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    public class Person
    {
        //Person has a firstname and lastname properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //void method to prints the full name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
