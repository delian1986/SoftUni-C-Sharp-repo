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
            Dictionary<string, int> myDic = new Dictionary<string, >();
            string inputLine;
            //long count = 0;
            List<string> minerals = new List<string>(); 
            do
            {
                //count++;
                inputLine = Console.ReadLine();
                minerals.Add(inputLine);

            } while (inputLine!="stop");

            for (int i = 0; i < minerals.Count-1; i+=2)
            {
                
                myDic.Add(minerals[i], minerals[i + 1]);
            }
            var result = myDic
  .Select(d => d)
  .GroupBy(
    kvp => kvp.Key,
    (key, kvps) => new { Key = key, Value = kvps.Sum(kvp => kvp.Value) }
  )
  .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in myDic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
