using System;
using System.Linq;

namespace _05.Java
{
    class java
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            //top
            for (int i = 0; i < size; i++)
            {
                Console.Write(string.Concat(Enumerable.Repeat(" ", size)));
                Console.Write(string.Concat(Enumerable.Repeat("~ ", 2)));
                Console.WriteLine("~");
            }

            //bodyUp
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 3 * size + 5)));

            for (int i = 0; i < size-3; i++)
            {
                if (size / 2 == i+1)
                {
                    Console.Write('|');
                    Console.Write(string.Concat(Enumerable.Repeat("~", size)));
                    Console.Write("JAVA");
                    Console.Write(string.Concat(Enumerable.Repeat("~", size)));
                    Console.WriteLine('|');

                }
                Console.Write('|');
                Console.Write(string.Concat(Enumerable.Repeat("~", 3 * size)));
                Console.Write('|');
                Console.Write(string.Concat(Enumerable.Repeat(" ", size-1)));
                Console.WriteLine('|');
            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 3 * size + 5)));

            //bottom
            var blank = 0;

            for (int i = 0; i <= size; i++)
            {

                Console.Write(string.Concat(Enumerable.Repeat(' ',blank)));
                Console.Write('\\');
                 Console.Write(string.Concat(Enumerable.Repeat("@", 3 * size
                     +1)));
                Console.WriteLine('/');
                    size --;
                blank++;
            }
        }
    }
}
