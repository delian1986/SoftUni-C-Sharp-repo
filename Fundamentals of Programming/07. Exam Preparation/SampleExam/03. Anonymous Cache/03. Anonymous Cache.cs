using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AnonymousCache
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Dictionary<string, Dictionary<string, long>> myDic = new Dictionary<string, Dictionary<string, long>>();

        List<string> listDataSets = new List<string>();

        while (input != "thetinggoesskrra")
        {
            string[] tokens = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

            string dataSet = String.Empty;
            string dataKey = String.Empty;
            long dataSize = 0L;

            if (tokens.Length == 1)
            {
                dataSet = tokens[0];
                listDataSets.Add(dataSet);
            }
            else
            {
                dataSet = tokens[2];
                dataKey = tokens[0];
                dataSize = long.Parse(tokens[1]);

                if (!myDic.ContainsKey(dataSet))
                {
                    myDic.Add(dataSet, new Dictionary<string, long>());
                }
                myDic[dataSet][dataKey] = dataSize;
            }
            input = Console.ReadLine();
        }

        SortedDictionary<string, SortedDictionary<string, long>> resDic = new SortedDictionary<string, SortedDictionary<string, long>>();

        foreach (var item in listDataSets)
        {
            if (!myDic.ContainsKey(item))
            {
                myDic.Remove(item);
            }
        }

        if (listDataSets.Count > 0)
        {
            var res = myDic.OrderByDescending(x => x.Value.Sum(e => e.Value)).First();
                Console.WriteLine($"Data Set: {res.Key}, Total Size: {res.Value.Sum(x=>x.Value)}");
            foreach (var item in res.Value)
            {
                Console.WriteLine($"$.{item.Key}");
            }
        }
    }


}


