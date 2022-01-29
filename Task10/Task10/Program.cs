using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfaceTest obj = new InterfaceTest();
            obj.brain();
            obj.talkEnglish();
            obj.walk();

        }
    }
    interface IAnimals
    {
        void walk();
        void brain();
        void talkEnglish();

        //} 
    }
    class InterfaceTest : IAnimals
    {
        public string name = "arpit";
        public void walk() // here I have given implementation of the interface method 
        {
            Console.Write("Animals can walk\n");
        }
        public void brain()// here I have given implementation of the interface method 
        {
            Console.Write("Animals also have a brain\n");
        }
        public void talkEnglish()// here I have given implementation of the interface method 
        {
            Console.Write("Animals can't talk in english\n");
        }
    }

}
