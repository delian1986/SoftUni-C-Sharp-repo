using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> myDic = new Dictionary<string, long>();

            List<string> inputLine = Console.ReadLine().Split(new[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> cards = new List<string>();


            while (inputLine[0] != "JOKER")
            {
                //remove same cards
                for (int i = 1; i < inputLine.Count; i++)
                {
                    for (int j = 1; j < inputLine.Count; j++)
                    {
                        if ( i!=j&&inputLine[i] == inputLine[j])
                        {
                            inputLine.Remove(inputLine[j]);
                        }
                    }
                }


                var hands = inputLine.Skip(1);

                foreach (var item in hands)
                {

                    var card = item[0];
                    var num = item[1];
                    long res = 0;

                    if (card=='1')
                    {
                        num = item[2];
                    }

                    if (card=='2')
                    {
                        res += 2;
                    }
                    else if (card=='3')
                    {
                        res += 3;
                    }
                    else if (card=='4')
                    {
                        res += 4;
                    }
                    else if (card == '5')
                    {
                        res += 5;
                    }
                    else if (card == '6')
                    {
                        res += 6;
                    }
                    else if (card == '7')
                    {
                        res += 7;
                    }
                    else if (card == '8')
                    {
                        res += 8;
                    }
                    else if (card == '9')
                    {
                        res += 9;
                    }
                    else if (card == '1')
                    {
                        res += 10;
                    }
                    else if (card == 'J')
                    {
                        res += 11;
                    }
                    else if (card == 'Q')
                    {
                        res += 12;
                    }
                    else if (card == 'K')
                    {
                        res += 13;
                    }
                    else if (card == 'A')
                    {
                        res += 14;
                    }

                    if (num=='S')
                    {
                        res *= 4;
                    }
                    else if (num=='H')
                    {
                        res *= 3;
                    }
                    else if (num=='D')
                    {
                        res *= 2;
                    }
                    else if (num=='C')
                    {
                        res *= 1;
                    }

                    if (!myDic.ContainsKey(inputLine[0]))
                    {
                        myDic.Add(inputLine[0], res);
                    }
                    else
                    {
                        myDic[inputLine[0]] += res;
                    }

                }

                inputLine = Console.ReadLine().Split(new[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            };

            foreach (var item in myDic)
            {
                Console.Write(item.Key);
                Console.Write(": ");
                Console.WriteLine(item.Value);
            }
        }
    }
}
