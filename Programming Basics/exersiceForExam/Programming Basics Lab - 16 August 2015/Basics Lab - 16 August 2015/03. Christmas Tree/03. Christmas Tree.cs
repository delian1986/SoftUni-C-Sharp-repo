using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var needle = 1;
            var outside = n;
            //top
            Console.Write(new string('\'', outside));
            Console.Write(new string('^', needle));
            Console.WriteLine(new string('\'', outside));

            needle += 2;
            outside--;

            //upperBody
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('\'', outside));
                Console.Write(new string('^', needle));
                Console.WriteLine(new string('\'', outside));
                needle += 2;
                outside--;
            }
            needle = 3;
            outside = n-1 ;
            for (int i = 0; i < n/2+1; i++)
            {
                
                Console.Write(new string('\'', outside));
                Console.Write(new string('^', needle));
                Console.WriteLine(new string('\'', outside));
                needle += 2;
                outside--;
            }

            //bott
            outside = n - 1;
            for (int i = 0; i < n/2+1; i++)
            {
                Console.Write(new string('\'',outside));
                Console.Write(string.Concat("| |"));
                Console.WriteLine(new string('\'', outside));

            }
            Console.WriteLine(new string('-',n*2+1));




        }
    }
}
