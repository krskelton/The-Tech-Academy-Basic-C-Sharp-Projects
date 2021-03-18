using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    class Employee : Person
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("This is outpitting from the Employee class!");
            base.SayName();
        }
        
        //override the operator == to determine if the employees are the same using the id
        public static string operator== (Employee employee1, Employee employee2)
        {
            //if the ids match then the employees are the same
            if (employee1.Id == employee2.Id)
            {
                return "The employees are the same";
            }
            //if the employees ids do not match they are not the same
            else 
            {
                return "The employees are not the same";
            }
        }
        //It said it needed the opposite method != since we have the ==, 
        //so this one would run if you call the not equal to operator
        public static string operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                return "The employees are not the same";
            }
            else
            {
                return "The employees are the same";
            }
        }
    }
}
