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
            Dictionary<string, long> myDic = new Dictionary<string, long>();

            Dictionary<string, List<string>> playerHands = new Dictionary<string, List<string>>();

            List<string> playerCards = new List<string>();

            List<string> inputLine = Console.ReadLine().Split(new[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (inputLine[0] != "JOKER")
            {
                foreach (var item in inputLine.Skip(1))
                {
                    playerCards.Add(item);
                }
                if (!playerHands.ContainsKey( inputLine[0]))
                {
                    playerHands.Add(inputLine[0], playerCards);

                }
                else
                {
                   // playerHands[inputLine[0]] + playerCards;
                }

                inputLine = Console.ReadLine().Split(new[] { ':', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        }
    }
}
