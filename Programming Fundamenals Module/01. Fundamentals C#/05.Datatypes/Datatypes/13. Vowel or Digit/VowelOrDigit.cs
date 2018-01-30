using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char symb=char.Parse(Console.ReadLine());

            if (symb=='a'||symb=='e'||symb=='i'||symb=='o'||symb=='u')
            {
                Console.WriteLine("vowel");
            }
            else if (symb-48>=0&&symb-48<=9)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
