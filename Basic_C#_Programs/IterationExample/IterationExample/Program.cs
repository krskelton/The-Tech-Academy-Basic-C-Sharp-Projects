using System;
using System.Collections.Generic;

namespace IterationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            for (int i = 0; i < testScores.Length; i++) {
                if (testScores[i] > 85) {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }
            //Console.ReadLine();

            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            for (int j = 0; j < names.Length; j++) {
                Console.WriteLine(names[j]);
            }

            List<int> scores = new List<int>();
            scores.Add(98);
            scores.Add(99);
            scores.Add(81);
            scores.Add(72);
            scores.Add(70);

            foreach (int score in scores) {
                if (score > 85) {
                    Console.WriteLine("Passing test score: " + score);
                }
            }

            List<string> namesList = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            foreach (string name in namesList) {
                Console.WriteLine(name);
            }

            List<int> testScores2 = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score2 in testScores2) {
                if (score2 > 85) {
                    passingScores.Add(score2);
                }
            }
            Console.WriteLine(passingScores.Count);

            Console.ReadLine();
        }
    }
}