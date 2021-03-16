using System;

namespace NamingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            NamingParameters naming = new NamingParameters();
            //call the method, specify the parameters by name
            NamingParameters.Naming(num1: 2, num2: 4);
            Console.ReadLine();
        }
    }
}
