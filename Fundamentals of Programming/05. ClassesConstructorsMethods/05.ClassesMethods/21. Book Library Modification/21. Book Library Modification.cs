using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace _21.Book_Library_Modification
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            SortedDictionary<string, DateTime> myDic = new SortedDictionary<string, DateTime>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                var date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                if (!myDic.ContainsKey(input[0]))
                {
                    myDic.Add(input[0], date);
                }
                else
                {
                    myDic[input[0]] = date;
                }

            }

            DateTime release = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in myDic.Where(x=>x.Value>release).OrderBy(x =>x.Value).ThenBy(x=>x.Key))
            {
                var date = item.Value.ToString("dd.MM.yyyy");
                Console.WriteLine($"{item.Key} -> {date}");
            }

        }
    }
}
