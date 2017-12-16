using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDic = new Dictionary<string, int>();
            string inputLine;
            //long count = 0;
            List<string> minerals = new List<string>();
            do
            {
                //count++;
                inputLine = Console.ReadLine();
                minerals.Add(inputLine);

            } while (inputLine != "stop");

            for (int i = 0; i < minerals.Count - 1; i += 2)
            {
                var key = minerals[i];
                var val = int.Parse(minerals[i + 1]);
                if (myDic.ContainsKey(key))
                {
                    myDic[key] = myDic[key] + val;
                }
                else
                {
                    myDic.Add(key, val);

                }

            }

            foreach (var item in myDic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}