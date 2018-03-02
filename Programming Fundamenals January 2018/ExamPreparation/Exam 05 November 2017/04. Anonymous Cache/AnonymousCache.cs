using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/835#1
/// </summary>
namespace _04._Anonymous_Cache
{
    class DataBase
    {
        public string DataSet { get; set; }
        public List<string> DataKey { get; set; }
        public List<long> DataSize { get; set; }
    }

    class AnonymousCache
    {
        static void Main()
        {
            List<DataBase> mainData = new List<DataBase>();
            List<string> cache = new List<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "thetinggoesskrra")
            {
                string[] args = input.Split(new[] { ' ', '{', '}', '-','|', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (args.Length == 1)
                {
                    string dataSet = args[0];
                    if (!cache.Contains(dataSet))
                    {
                        cache.Add(dataSet);
                    }
                }
                else
                {
                    string dataKey = args[0];
                    long dataSize = long.Parse(args[1]);
                    string dataSet = args[2];

                    DataBase data = new DataBase()
                    {
                        DataKey=new List<string>(),
                        DataSet=dataSet,
                        DataSize=new List<long>()
                    };

                    if (!mainData.Any(x=>x.DataSet==dataSet))
                    {
                        mainData.Add(data);
                    }
                    var curr=mainData.Where(x=>x.DataSet==dataSet).First();
                    curr.DataKey.Add(dataKey);
                    curr.DataSize.Add(dataSize);
                }
            }

            foreach (var set in mainData.Where(x=>cache.Contains(x.DataSet)).OrderByDescending(x=>x.DataSize.Sum()))
            {
                Console.WriteLine($"Data Set: {set.DataSet}, Total Size: {set.DataSize.Sum()}");
                foreach (var item in set.DataKey)
                {
                    Console.Write("$.");
                    Console.WriteLine(string.Join("",item));
                }
                    return;
            }
        }
    }
}
