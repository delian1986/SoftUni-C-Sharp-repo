using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> myDic = new Dictionary<int, int>();

            
            foreach (var item in inputLine)
            {
                if (myDic.ContainsKey(item))
                {
                    myDic[item]++;
                }
                else
                {
                    myDic.Add(item, 1);
                }
            }


            var order = myDic.OrderByDescending(x => x.Value);

            var firstElement = order.First();
            var firstElementKey = firstElement.Key;
            Console.WriteLine(firstElementKey);
        }
    }
}
