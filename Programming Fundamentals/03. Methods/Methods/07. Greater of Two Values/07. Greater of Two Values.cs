using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    var val1 = int.Parse(Console.ReadLine());
                    var val2 = int.Parse(Console.ReadLine());
                    int max = GetMax(val1, val2);
                    Console.WriteLine(max);
                    return;

                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    char bigger = (char)GetMax(char1, char2);
                    Console.WriteLine(bigger);
                    return;
                case "string":
                    var str1 = Console.ReadLine();
                    var str2 = Console.ReadLine();
                    string longer = GetMax(str1, str2);
                    Console.WriteLine(longer);
                    return;
            }
        }

        private static string GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }

        static int GetMax(int val1, int val2)
        {
            return Math.Max(val1, val2);
        }
    }
}
