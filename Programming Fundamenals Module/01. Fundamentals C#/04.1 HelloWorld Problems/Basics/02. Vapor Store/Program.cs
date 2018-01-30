using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money=decimal.Parse(Console.ReadLine());
            decimal startMoney=money;
            Dictionary<string,decimal>gameList=new Dictionary<string, decimal>()
            {
                {"OutFall 4", 39.99m},
                {"CS: OG", 15.99m},
                {"Zplinter Zell",19.99m},
                {"Honored 2",59.99m},
                {"RoverWatch",29.99m},
                {"RoverWatch Origins Edition",39.99m}
            };

            string input=Console.ReadLine();
            while (input!="Game Time")
            {
                if (gameList.ContainsKey(input))
                {
                    decimal gamePrice=gameList[input];
                    if (money>=gamePrice)
                    {
                        Console.WriteLine($"Bought {string.Join("",gameList.Keys.Where(x=>x==input))}");
                        money-=gamePrice;
                        if (money<=0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                input=Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${startMoney-money:f2}. Remaining: ${money:f2}");
        }
    }
}
