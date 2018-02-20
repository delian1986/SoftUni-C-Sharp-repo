using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Reversed_chars
{
    class ReversedChars
    {
        static void Main(string[] args)
        {
            char sym1 = char.Parse(Console.ReadLine());
            char sym2 = char.Parse(Console.ReadLine());
            char sym3 = char.Parse(Console.ReadLine());

            string text=string.Concat(sym1,sym2,sym3);
            string res=string.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                res+=text[i];
            }

            Console.WriteLine(res);
        }
    }
}
