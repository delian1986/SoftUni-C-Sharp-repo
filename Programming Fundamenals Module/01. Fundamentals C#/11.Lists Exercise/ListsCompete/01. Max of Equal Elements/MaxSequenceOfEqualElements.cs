using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Max_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList(); 

            var mostFrequent=nums.GroupBy(x=>x);
            

            foreach (var num in mostFrequent.OrderByDescending(x=>x.Count()))
            {
                var element=num.Key;
                var ocurr=num.Count();
                Console.WriteLine(string.Concat(Enumerable.Repeat(element+" ",ocurr)));
                break;
            }
        }
    }
}
