using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static Dictionary<string, string> simpleDigits = new Dictionary<string, string>()
        {
            { "0", "ноль" },
            { "1", "один" },
            { "2", "два" },
            { "3", "три" },
            { "4", "четыре" },
            { "5", "пять" },
            { "6", "шесть" },
            { "7", "семь" },
            { "8", "восемь" },
            { "9", "девять" }
        };
        static Dictionary<string, string> roundDigits = new Dictionary<string, string>()
        {
            { "2", "двадцать" },
            { "3", "тридцать" },
            { "4", "сорок" },
            { "5", "пятьдесят" },
            { "6", "шестьдесят" },
            { "7", "семьдесят" },
            { "8", "восемьдесят" },
            { "9", "девяносто" }
        };
        static Dictionary<string, string> from10To19 = new Dictionary<string, string>()
        {
            { "0", "десять" },
            { "1", "одиннадцать" },
            { "2", "двенадцать" },
            { "3", "тринадцать" },
            { "4", "четырнадцать" },
            { "5", "пятнадцать" },
            { "6", "шестнадцать" },
            { "7", "семнадцать" },
            { "8", "восемнадцать" },
            { "9", "девятнадцать" },
        };

        static Dictionary<string, string> hundreds = new Dictionary<string, string>()
        {
            { "1", "сто" },
            { "2", "двести" },
            { "3", "триста" },
            { "4", "четыреста" },
            { "5", "пятьсот" },
            { "6", "шестьсот" },
            { "7", "семьсот" },
            { "8", "восемьсот" },
            { "9", "девятьсот" },
        };

        static Dictionary<string, string> thousands = new Dictionary<string, string>()
        {
            { "1", "одна тысяча" },
            { "2", "две тысячи" },
            { "3", "три тысячи" },
            { "4", "четыре тысячи" },
            { "5", "пять тысяч" },
            { "6", "шесть тысяч" },
            { "7", "семь тысяч" },
            { "8", "восемь тысяч" },
            { "9", "девять тысяч" },
        };
        static string Units(string input)
        {
            return simpleDigits[input];
        }
        static string Tens(string input)
        {
            string firstDigit = Convert.ToString(input[0]);
            string secondDigit = Convert.ToString(input[1]);
            if (firstDigit == "0")
            {
                return Units(Convert.ToString(input[1]));
            }
            else if (firstDigit == "1")
            {
                return from10To19[secondDigit];
            }
            else
            {
                if (secondDigit == "0")
                {
                    return roundDigits[firstDigit];
                }
                else
                {
                    return roundDigits[firstDigit] + " " + Units(secondDigit);
                }

            }
        }
        static string Hundreds(string input)
        {
            string firstDigit = Convert.ToString(input[0]);
            if (input.Contains("000"))
            {
                return "";
            }
            else if (input.Substring(1, 2).Contains("00"))
            {
                return hundreds[firstDigit];
            }
            else if (firstDigit == "0" && !input.Substring(1, 2).Contains("00"))
            {
                return Tens(input.Substring(1, 2));
            }
            else
            {
                return hundreds[firstDigit] + " " + Tens(input.Substring(1, 2));
            }

        }
        static string Thousands(string input)
        {
            string firstDigit = Convert.ToString(input[0]);

            return thousands[firstDigit] + " " + Hundreds(input.Substring(1, 3));

        }
        static void Main(string[] args)
        {
            string input;
            Console.Write("Enter a number in the range [ 0; 9999 ]: ");
            input = Console.ReadLine();
            try
            {
                Convert.ToInt32(input);
                Console.WriteLine();
                switch (input.Length)
                {
                    case 1:
                        Console.WriteLine(Units(input));
                        break;
                    case 2:
                        Console.WriteLine(Tens(input));
                        break;
                    case 3:
                        Console.WriteLine(Hundreds(input));
                        break;
                    case 4:
                        Console.WriteLine(Thousands(input));
                        break;
                    default:
                        Console.WriteLine("Out of program's range");
                        break;

                }
            }
            catch
            {
                Console.WriteLine("\nINPUT ERROR! \nNumber entered incorrectly");
            }
        }
    }
}
