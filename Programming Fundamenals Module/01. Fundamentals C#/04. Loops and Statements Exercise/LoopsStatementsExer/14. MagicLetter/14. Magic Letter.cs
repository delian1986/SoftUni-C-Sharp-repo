using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
           char a = char.Parse(Console.ReadLine());
           char b = char.Parse(Console.ReadLine());
           char c = char.Parse(Console.ReadLine());

           for (char i = a; i <= b; i++)
           {
               for (char j = a; j <= b; j++)
               {
                   for (char k = a; k <= b; k++)
                   {
                       string text= ($"{i}{j}{k} ");

                       if (text.Contains(c))
                       {
                           continue;
                       }
                        Console.Write(text);
                   }
               }
           }

        }
    }
}
