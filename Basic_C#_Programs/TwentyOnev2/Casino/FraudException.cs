using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class FraudException : Exception
    {
        //two constructors, one overloads the other
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }
    }
}
