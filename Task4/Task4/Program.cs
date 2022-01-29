using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("N = ");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.Write("M = ");
                int M = Convert.ToInt32(Console.ReadLine());

                for (int i = M; i > 0; i--)
                {
                    Console.Write(--N + " ");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
