using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temps = { 10.0, 11.3, 4.5, -2.0, 3.6, -3.3, 0, 0 };

            Console.WriteLine("Temperatures:\n");
            foreach (var temp in temps)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine("\n\nMax = {0}\nMin = {1}", temps.Max(), temps.Min());
        }
    }
}
