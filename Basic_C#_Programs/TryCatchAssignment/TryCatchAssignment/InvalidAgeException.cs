using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatchAssignment
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException()
            : base() { }
        public InvalidAgeException(string message)
            : base(message) { }
    }
}
