using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> resDic = new Dictionary<string, Dictionary<string, long>>();

            //Dictionary<string, Dictionary<string, long>> cacheDic = new Dictionary<string, Dictionary<string, long>>();

            List<string> cache = new List<string>();

            string inputLine = string.Empty;

            while ((inputLine = Console.ReadLine()) != "thetinggoesskrra")
            {
                string[] tokens =
                    inputLine.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string dataSet = string.Empty;
                string dataKey = string.Empty;
                long dataSize = 0L;


                if (tokens.Length == 1)
                {
                    dataSet = tokens[0];
                    cache.Add(dataSet);
                    continue;
                }
                else
                {
                    dataSet = tokens[2];
                    dataKey = tokens[0];
                    dataSize = long.Parse(tokens[1]);
                }


                if (!resDic.ContainsKey(dataSet))
                {
                    resDic.Add(dataSet, new Dictionary<string, long>());


                }

                resDic[dataSet].Add(dataKey, 0);
                resDic[dataSet][dataKey] += dataSize;


            }

            foreach (var item in cache)
            {
                if (!cache.Contains(item))
                {
                    resDic.Remove(item);
                }
            }

            if (cache.Count > 0)
            {
                var res = resDic.OrderByDescending(x => x.Value.Sum(y => y.Value)).First();

                Console.WriteLine($"Data Set: {res.Key}, Total Size: {res.Value.Sum(x=>x.Value)}");
                foreach (var item in res.Value)
                {
                    Console.WriteLine($"$.{item.Key}");

                }

            }


        }
    }
}
