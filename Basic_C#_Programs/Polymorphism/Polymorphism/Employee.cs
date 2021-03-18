using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    //Employee inherits from both the class Person and the interface IQuittable
    class Employee : Person, IQuittable
    {
        //To implement the SayName method in Employee, it needs to be overriden.
        public override void SayName()
        {
            Console.WriteLine("This is outputting from the Employee class!");
            base.SayName();
        }
        //Call the IQuittable method
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
