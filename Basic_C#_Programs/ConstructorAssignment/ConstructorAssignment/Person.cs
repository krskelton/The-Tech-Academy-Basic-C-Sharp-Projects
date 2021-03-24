using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAssignment
{
    public class Person
    {
        //constructor chaining
        public Person(string lastName) : this(lastName, "Skelton")
        { 
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
