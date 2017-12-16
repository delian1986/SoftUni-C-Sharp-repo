using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDic = new Dictionary<string, string>();
            //List<string> temp = new List<string>();

            string inputLine = "";
            string inputLine2 = "";



            while (true)
            {
                inputLine = Console.ReadLine();
                if (inputLine != "stop")
                {
                    inputLine2 = Console.ReadLine();
                }
                else if (inputLine == "stop")
                {
                    break;
                }


                var temp = inputLine2.Split('.').ToArray();

                if (temp[1] == "us" || temp[1] == "uk")
                {
                    continue;
                }
                else
                {
                    var value = string.Join(".", temp);
                    myDic.Add(inputLine, value);

                }
            }

            foreach (var item in myDic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}

