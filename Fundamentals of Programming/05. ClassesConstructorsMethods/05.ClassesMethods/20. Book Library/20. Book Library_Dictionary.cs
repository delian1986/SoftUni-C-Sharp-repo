using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> myDic = new SortedDictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (!myDic.ContainsKey(input[1]))
                {
                    myDic.Add(input[1], 0);
                }
                var price = decimal.Parse(input[input.Length - 1]);
                myDic[input[1]] += price;
            }

            foreach (var item in myDic.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }

        }
    }
}

  
