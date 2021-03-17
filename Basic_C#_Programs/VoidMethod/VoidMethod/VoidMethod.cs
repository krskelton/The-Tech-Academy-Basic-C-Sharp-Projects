using System;
using System.Collections.Generic;
using System.Text;

namespace VoidMethod
{
    public class VoidMethod
    {
        //the following method demonstrates a void method that outputs the value instead of returning it
        public void DivideInt(int passedVariable)
        {
            Console.WriteLine("The number you entered divided by 2 is: " + passedVariable / 2);
        }
        //the following method demonastrates using output parameters
        public void GetValues(out int num1, out int num2)
        {
            Console.WriteLine("Enter number 1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        //the next method will overload the DivideInt method
        //we will take two parameters instead of one allowing the user to divide by the number they choose
        public void DividInt(int passedVariable1, int passVariable2)
        {
            Console.WriteLine("Your first number, " + passedVariable1 + ", divided by your second number, " + passVariable2 + ", is " + passedVariable1 / passVariable2);
        }
    }
}
