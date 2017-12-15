using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> myDic = new SortedDictionary<double, int>();

            foreach (var item in nums)
            {
                if (myDic.ContainsKey(item))
                {
                    myDic[item]++;
                }
                else
                {
                    myDic.Add(item,1);
                }
            }

            foreach (var item in myDic)
            {
                var keys = myDic.Keys;
                var val = myDic.Values;

                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
