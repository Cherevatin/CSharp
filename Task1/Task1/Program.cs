using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;

            int[] elements = new int[size];

            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write("Element #{0}: ", i + 1);
                elements[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Input:");
            Out(elements);
            Array.Reverse(elements);
            Console.WriteLine("Output:");
            Out(elements);
        }
        static void Out(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
