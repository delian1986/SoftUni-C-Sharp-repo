using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string deliminter = Console.ReadLine();
            var num = int.Parse(Console.ReadLine());
            string concat = "";
            for (int i = 0; i < num; i++)
            {
                var text = Console.ReadLine();
                

                if (i==num-1)
                {
                    concat += text;
                }
                else
                {
                    concat += text + deliminter;
                }
                //concat += text+deliminter ;

            }
            Console.WriteLine(concat);
        }
    }
}
