using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    interface IAnimal
    {
        string Describe();
        string Name
        {
            get;
            set;
        }
    }
    class Dog : IAnimal, IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj is IAnimal)
                return this.Name.CompareTo((obj as IAnimal).Name);
            return 0;
        }
        public string Name { get; set; }
        public Dog(string name)
        {
            Name = name;
        }
        public string Describe()
        {
            return "Здравствуйте, я собака, и меня зовут " + Name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Fido"));
            dogs.Add(new Dog("Bob"));
            dogs.Add(new Dog("Adam"));
            dogs.Sort();
            foreach (Dog dog in dogs)
                Console.WriteLine(dog.Describe());
        }
    }



}
