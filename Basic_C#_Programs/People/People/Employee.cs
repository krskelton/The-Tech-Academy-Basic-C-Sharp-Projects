using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    //Employee inherits from Person
    public class Employee : Person
    {
        //Add an ID for the Employees
        public int Id { get; set; }
    }
}
