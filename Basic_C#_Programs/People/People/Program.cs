using System;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and initialize an Employee object
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //call the superclass method SayName()
            employee.SayName();

            Console.ReadLine();
        }
    }
}
