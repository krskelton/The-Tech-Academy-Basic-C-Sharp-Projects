using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class Person
    {
        //two properties, first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //create a virtual method so that classes that inherit from this class can customize the method
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
