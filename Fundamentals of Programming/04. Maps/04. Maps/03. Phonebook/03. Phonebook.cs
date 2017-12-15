using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDic = new Dictionary<string, string>();

            string[] inputLine = new string[3];


            do
            {
                inputLine = Console.ReadLine().Split().ToArray();

                if (inputLine[0] == "A")
                {
                    if (myDic.ContainsKey(inputLine[1]))
                    {
                        myDic.Remove(inputLine[1]);
                        myDic.Add(inputLine[1], inputLine[2]);
                    }
                    else
                    {
                        myDic.Add(inputLine[1], inputLine[2]);

                    }
                }

                else if (inputLine[0] == "S")
                {
                    if (!myDic.ContainsKey(inputLine[1]))
                    {
                        Console.WriteLine($"Contact {inputLine[1]} does not exist.");
                    }
                    else if (myDic.ContainsKey(inputLine[1]))
                    {
                        var pair = myDic.FirstOrDefault(x => x.Key == inputLine[1]);
                        var key = pair.Key;
                        var val = pair.Value;
                    Console.WriteLine("{0} -> {1}", key, val);
                    }


                }

            


            } while (inputLine[0] != "END");






        }
}
}
