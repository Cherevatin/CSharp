using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy g = new Guy();
            Console.Write("What is your name?:");
            g.name = Console.ReadLine();
            Console.Write("What is your age?:");
            g.age = int.Parse(Console.ReadLine());
            g.PrintData();

        }
    }
    class Guy
    {
        public string name;
        public int age;
        public void PrintData()
        {
            Console.WriteLine("Your name: {0}\nYour age: {1}", name, age);
        }
    }

}
