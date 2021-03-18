using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate a new employee
            Employee employee1 = new Employee();
            //assign the employee an id
            employee1.Id = 1;
            //instantiat another new employee
            Employee employee2 = new Employee();
            //assign the employee an id
            employee2.Id = 2;
            //determine if the employees are equal. 
            //This will call the overridden operator method we defined in the Employee class
            Console.WriteLine(employee1 == employee2);

            Console.ReadLine();
        }
    }
}
