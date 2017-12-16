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
            Dictionary<string, List<int>> myDic = new Dictionary<string, List<int>>();

            List<string> inputLine = new List<string>();
            inputLine = Console.ReadLine().Split(':', ',').ToList();

            do
            {
                inputLine = Console.ReadLine().Split(':', ',').ToList();


            } while (inputLine[0]!="JOKER");
        }
    }
}
