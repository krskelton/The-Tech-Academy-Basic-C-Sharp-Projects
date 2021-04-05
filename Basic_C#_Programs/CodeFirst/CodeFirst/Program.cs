using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { FirstName = "Kristin", LastName = "Skelton" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.WriteLine("Student saved successfully!");

                foreach (var student in ctx.Students)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
                Console.ReadLine();
            }
        }
    }
}
