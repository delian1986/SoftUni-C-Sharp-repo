using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteFlip
{
    class ByteFlip
    {
        public static void Main()
        {
            var sequence=Console.ReadLine()
                .Split()
                .Where(x=>x.Length==2)
                .Select(x=> new string(x.Reverse().ToArray()))
                .Select(x=>Convert.ToChar(Convert.ToInt32(x,16)))
                .Reverse()
                .ToList();

            Console.WriteLine(string.Join("",sequence));
        }
    }
}