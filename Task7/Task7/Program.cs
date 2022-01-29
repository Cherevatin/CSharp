using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            Array.Reverse(words);
            Console.Write("Reversed string: ");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
