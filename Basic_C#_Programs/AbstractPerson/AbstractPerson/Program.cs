using System;

namespace AbstractPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new Employee object
            //set first and last name
            Employee employee = new Employee() { FirstName= "Sample", LastName = "Student" };
            //call SayName method
            employee.SayName();

            Console.ReadLine();
        }
    }
}
