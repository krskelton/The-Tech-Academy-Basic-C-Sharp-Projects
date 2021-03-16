using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsWithOptionalParameters
{
    class OptionalParameters
    {
        //method takes two integers, one of them is optional, perform math, reutrn integer
        public int optional(int num1, int num2 = 1) 
        {
            return num1 + num2;
        }
    }
}
