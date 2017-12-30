using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            TypeComparer(input);
        }

        private static void TypeComparer(string input)
        {
            if (input == "int")
            {
                int val1 = int.Parse(Console.ReadLine());
                int val2 = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Max(val1, val2));
            }
            else if (input == "char")
            {
                char val1 = char.Parse(Console.ReadLine());
                char val2 = char.Parse(Console.ReadLine());
                if (val1>val2)
                {
                    Console.WriteLine(val1);
                }
                else
                {
                    Console.WriteLine(val2);
                }
            }
            else if (input =="string")
            {
                string val1 = Console.ReadLine();
                string val2 = Console.ReadLine();

                string[] comparer =
                {
                    val2,
                    val1,
                    val1,

                };
                var comp= (val1.CompareTo(val2)+1);
                Console.WriteLine(comparer[comp]);
            }
        }
    }
}
