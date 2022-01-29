using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {

        class Calculator
        {
            public void Sum(double a, double b)
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            }
            public void Diff(double a, double b)
            {
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            }
            public void Mult(double a, double b)
            {
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            }
            public void Div(double a, double b)
            {
                if (b != 0)
                {
                    Console.WriteLine("{0} / {1} = {2}", a, b, Convert.ToInt32(a) / Convert.ToInt32(b));
                }
                else
                {
                    Console.WriteLine("Division by zero error");
                }

            }
        }
        static void Main(string[] args)
        {
            double firstNumber = 0;
            double secondNumber = 0;
            Calculator C = new Calculator();

            bool exit = false;
            while (!exit)
            {
                Console.Write("Enter the first number: ");
                try
                {
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    try
                    {
                        secondNumber = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Choose operation: \n1 - suma\n2 - difference\n3 - multiplication\n4 - division\n5 - exit\nMy choise: ");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                Console.Clear();
                                C.Sum(firstNumber, secondNumber);
                                break;
                            case 2:
                                Console.Clear();
                                C.Diff(firstNumber, secondNumber);
                                break;
                            case 3:
                                Console.Clear();
                                C.Mult(firstNumber, secondNumber);
                                break;
                            case 4:
                                Console.Clear();
                                C.Div(firstNumber, secondNumber);
                                break;
                            case 5:
                                exit = true;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Operation doesn't exist");
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nINPUT ERROR\nNumber entered incorrectly");
                    }

                }
                catch
                {
                    Console.WriteLine("\nINPUT ERROR\nNumber entered incorrectly");
                }
            }
        }
    }
}
