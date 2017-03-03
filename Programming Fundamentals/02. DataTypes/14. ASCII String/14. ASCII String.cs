using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string text = "";
            for (int i = 0; i < num; i++)
            {
                int asci = int.Parse(Console.ReadLine());
                text += Convert.ToChar(asci);
            }
            Console.WriteLine(text);
        }
    }
}
