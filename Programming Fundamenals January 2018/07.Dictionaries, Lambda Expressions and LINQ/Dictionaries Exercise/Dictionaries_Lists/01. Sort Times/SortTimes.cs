using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// This program sort list of strings by Linq.
/// </summary>

namespace _01._Sort_Times
{
    class SortTimes
    {
        static void Main()
        {
            List<string>times=Console.ReadLine().Split().ToList();
            times.Sort();
            Console.WriteLine(string.Join(", ",times));

        }
    }
}
