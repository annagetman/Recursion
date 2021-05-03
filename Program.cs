using System;
using System.Collections.Generic;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Filling.Boxes = new List<int>() { 33, 40 };
            Filling filling = new Filling(100);
            filling.CreateGraph();
            filling.WriteAllLeaves();
            //Console.WriteLine(f(4));
            //Console.WriteLine(f(5));
            //Combination(3, new List<string>() { "aaa", "bbb", "ccc" });
        }

        static int f(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * f(n - 1);
            }
        }

        static void Combination(int n, List<string> books, List<string> current = null)
        {
            if (current is null)
            {
                current = new List<string>();
            }
            if (current.Count == n)
            {
                foreach (string b in current)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            else
            {
                foreach (string b in books)
                {
                    List<string> tmp = new List<string>(current);
                    tmp.Add(b);
                    Combination(n, books, tmp);
                }
            }
        }
    }
}

