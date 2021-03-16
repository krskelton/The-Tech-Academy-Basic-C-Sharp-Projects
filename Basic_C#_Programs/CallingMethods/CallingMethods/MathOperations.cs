using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class MathOperations
    {
        //This method adds 1 to the integer passed to it
        public int AddInt(int userResponse)
        {
            return userResponse + 1;
        }
        //This method multiplies the integer by itself
        public int MultiplyInt(int userResponse)
        {
            return userResponse * userResponse;
        }
        //This method divides the integer provided by 2
        public int DivideInt(int userReponse)
        {
            return userReponse / 2;
        }
    }
}
