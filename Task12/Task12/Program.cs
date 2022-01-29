using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Guy> guys = new List<Guy>();
            guys.Add(new Guy("Bob", 10));
            guys.Add(new Guy("Jack", 15));
            guys.Add(new Guy("John", 17));
            guys.Add(new Guy("Oliver", 24));
            guys.Add(new Guy("Harry", 36));
            guys.Add(new Guy("Thomas", 8));
            guys.Add(new Guy("Oscar", 18));
            guys.Add(new Guy("Jacob", 12));
            guys.Add(new Guy("Charley", 20));
            guys.Add(new Guy("George", 29));

            int youngestAge = int.MaxValue;
            int youngestGuy = 0;
            Console.WriteLine("\n///// List of all guys:");
            foreach (var (guy, index) in guys.Select((guy, index) => (guy, index)))
            {
                Console.WriteLine("Guy #{0}:", index + 1);
                guy.PrintData();
                if (guy.Age < youngestAge)
                {
                    youngestGuy = index;
                    youngestAge = guy.Age;
                }
            }
            Console.WriteLine("\n///// The youngest guy:");
            guys[youngestGuy].PrintData();

            Console.WriteLine("\n///// Guys aged 15 to 25:");
            foreach (var (guy, index) in guys.Select((guy, index) => (guy, index)))
            {
                
                if (guy.Age >= 15 && guy.Age <= 25)
                {
                    Console.WriteLine("Guy #{0}:", index + 1);
                    guy.PrintData();
                }
            }

            Console.WriteLine("\n///// Guys whose name starts with the letter 'C':");
            foreach (var (guy, index) in guys.Select((guy, index) => (guy, index)))
            {
                
                if (guy.Name.StartsWith("C"))
                {
                    Console.WriteLine("Guy #{0}:", index + 1);
                    guy.PrintData();
                }
            }

            Console.WriteLine("\n///// Guys whose name contains the letter 'C':");
            foreach (var (guy, index) in guys.Select((guy, index) => (guy, index)))
            {
                
                if (guy.Name.Contains("C") || guy.Name.Contains("c"))
                {
                    Console.WriteLine("Guy #{0}:", index + 1);
                    guy.PrintData();
                }
            }

            var sortedGuys = guys.OrderByDescending(g => g.Age);
            Console.WriteLine("\n///// Sorted list of all guys by AGE:");
        
            foreach (var (guy,index) in sortedGuys.Select((guy, index) => (guy, index)))
            {
                Console.WriteLine("Guy #{0}:", index + 1);
                guy.PrintData();
            }
            Console.WriteLine("///// GROUPS //////\n");
            var groupedGuys = guys.GroupBy(g => g.GetAgeGroup());
            foreach (var groupedGuy in groupedGuys)
            {
                Console.WriteLine("///// " + groupedGuy.Key + ":");
                foreach (var (guy, index) in groupedGuy.Select((guy, index) => (guy, index)))
                {
                    Console.WriteLine("Guy #{0}:", index + 1);
                    guy.PrintData();
                }
                
            }



        }
    }
    class Guy
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Guy(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void PrintData()
        {
            Console.WriteLine("Name: {0}\nAge: {1}\n", Name, Age);
        }

        public string GetAgeGroup()
        {
            if (Age < 13)
                return "Children";
            if (Age < 20)
                return "Teenagers";
            return "Adults";
        }
        
    }

}
