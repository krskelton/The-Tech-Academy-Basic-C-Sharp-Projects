using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPerson
{
    //Employee inherits from Person
    class Employee : Person
    {
        //To implement the SayName method in Employee, it needs to be overriden. 
        public override void SayName()
        {
            Console.WriteLine("This is outputting from the Employee class! ");
            base.SayName();
        }
    }
}
