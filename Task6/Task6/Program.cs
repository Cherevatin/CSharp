using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string inputNumber = Console.ReadLine();
            try
            {
                Convert.ToInt32(inputNumber);
                Console.Write("Enter a number to search: ");
                string desiredNumber = Console.ReadLine();
                try
                {
                    Convert.ToInt32(desiredNumber);
                    int count = 0;
                    while (inputNumber.Contains(desiredNumber))
                    {
                        inputNumber = inputNumber.Substring(inputNumber.IndexOf(Convert.ToChar(desiredNumber)) + 1);
                        count++;
                    }
                    Console.WriteLine("Number of occurrences of a number '{0}' = {1}", desiredNumber, count);

                }
                catch
                {
                    Console.WriteLine("Number must be a integer number");
                }

            }
            catch
            {
                Console.WriteLine("Number must be a integer");
            }
        }
    }
}
