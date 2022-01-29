using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit;
            int sum = 0;

            Console.Write("Enter the limit: ");
            limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limit; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Sum of odd numbers = {0}", sum);
        }
    }
}
