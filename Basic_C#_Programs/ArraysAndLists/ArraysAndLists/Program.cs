using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            Console.WriteLine(numArray[3]);

            int[] numArray2 = new int[] { 5, 2, 10, 200, 5000 };

            Console.WriteLine(numArray2[3]);


            int[] numArray3 = { 5, 2, 10, 200, 5000 };

            numArray3[3] = 650;

            Console.WriteLine(numArray3[3]);

            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);
            Console.WriteLine(intList[0]);
            Console.ReadLine();
        }
    }
}
