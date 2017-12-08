using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine().ToLower();
            string text2 = Console.ReadLine().ToLower();

            if (text1==text2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
