using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UserLogs
{
    static void Main(string[] args)
    {
        var myDic = new SortedDictionary<string, Dictionary<string, int>>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            string[] splittedInput = input.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

            string ip = splittedInput[1];
            string user = splittedInput[5];
            if (!myDic.ContainsKey(user))
            {
                myDic.Add(user, new Dictionary<string, int>());
                myDic[user][ip] = 1;

            }
            else if (!myDic[user].ContainsKey(ip))
            {

                myDic[user][ip] = 1;

            }
            else if (myDic[user].ContainsKey(ip))
            {
                var count = myDic[user][ip];
                count++;
                myDic[user][ip] = count;
            }

        }

        foreach (var item in myDic)
        {
            Console.WriteLine($"{item.Key}:");
            Console.WriteLine(string.Join(", ", item.Value.Select(x=>$"{x.Key} => {x.Value}"))+".");
            
        }
    }
}
