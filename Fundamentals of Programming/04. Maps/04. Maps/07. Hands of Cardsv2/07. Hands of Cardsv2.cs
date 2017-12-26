using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Hands_of_Cardsv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> myDic = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                var command = input.Split(':');
                var name = command[0];
                var cards = command[1].Trim().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (!myDic.ContainsKey(name))
                {
                    myDic.Add(name, new Dictionary<string, int>());
                    AddCardsToPerson(myDic[name], cards);
                }
                else
                {
                    AddCardsToPerson(myDic[name], cards);

                }
                input = Console.ReadLine();

            }

            foreach (var name in myDic)
            {
                Console.WriteLine($"{name.Key}: {name.Value.Values.Sum()}");
            }
        }

        private static void AddCardsToPerson(Dictionary<string, int> myDic, string[] cards)
        {
            foreach (var item in cards)
            {
                if (!myDic.ContainsKey(item))
                {
                    myDic.Add(item, GetCardValue(item));
                }
            }
        }

        private static int GetCardValue(string item)
        {
            int power = 0;
            switch (item[0])
            {
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    power += (int)item[0] - 48;
                    break;
                case '1':
                    power += 10;
                    break;
                case 'J':
                    power += 11;
                    break;
                case 'Q':
                    power += 12;
                    break;
                case 'K':
                    power += 13;
                    break;
                case 'A':
                    power += 14;
                    break;
            }

            switch (item[item.Length-1])
            {
                case 'S':
                    power *= 4;
                    break;
                case 'H':
                    power *= 3;
                    break;
                case 'D':
                    power *= 2;
                    break;
                case 'C':
                    power *= 1;
                    break;
            }

            return power;
        }
    }
}
