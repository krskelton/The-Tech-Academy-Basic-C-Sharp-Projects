using System;
using System.Collections.Generic;
using System.Text;

namespace MethodExamples
{
    public class MethodExamples
    {
        //method that takes an integer, performs math operation and returns the answer
        public int MathOperation(int integer)
        {
            //add 2 to the integer passed in
            return integer + 2;
        }
        //method with same name that takes in a decimal, perform a different math operation and returns the answer
        public int MathOperation(decimal dec)
        {
            //multiply the decimal by 2
            decimal multiply = dec * 2.5m;
            //return an integer
            return Convert.ToInt32(multiply);
        }
        //method with same name, takes a string, converts it into an integer and does another math operation
        public int MathOperation(string stringInt)
        {
            //Convert the string to an integer
            int intString = Convert.ToInt32(stringInt);
            //divide the integer by 2
            return intString / 2;
        }
    }
}
