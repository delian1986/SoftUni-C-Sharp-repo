using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> myDic = new Dictionary<string, int>();

            foreach (var item in arr)
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

            List<string> resList = new List<string>();
            foreach (var item in myDic)
            {
                if (item.Value%2==1)
                {
                    resList.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ",resList));
        }
    }
}
