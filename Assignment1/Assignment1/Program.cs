using System;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Products.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { "|" }, StringSplitOptions.None);
                foreach(string part in parts)
                {
                    Console.Write($"{part, -10}");
                }

                Console.WriteLine();
            }
        }
    }
}
