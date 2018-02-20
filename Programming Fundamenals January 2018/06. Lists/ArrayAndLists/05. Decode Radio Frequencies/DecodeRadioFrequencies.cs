using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split();

            List<char> first = new List<char>();
            List<char> second = new List<char>();

            for (int i = 0; i < sequence.Length; i++)
            {
                string[] item = sequence[i].Split('.');
                int firstLetter = int.Parse(item[0]);
                int secondLetter = int.Parse(item[1]);

                if (firstLetter != 0)
                {
                    first.Insert(i, (char)firstLetter);
                }
                if (secondLetter != 0)
                {
                    second.Insert(i, (char)secondLetter);
                }
            }

            second.Reverse();
            var result=first.Concat(second).ToList();

            Console.WriteLine(string.Join("",result));
        }
    }
}
