using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> myList = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            myList.Sort();

            Console.WriteLine(string.Join(" <= ",myList));
        }
    }
}
