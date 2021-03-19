using System;
using System.Collections.Generic;
using System.Text;

namespace Parameters
{
    public class Employee<T>
    {
        //create a generic list
        public List<T> Things { get; set; }
    }
}
