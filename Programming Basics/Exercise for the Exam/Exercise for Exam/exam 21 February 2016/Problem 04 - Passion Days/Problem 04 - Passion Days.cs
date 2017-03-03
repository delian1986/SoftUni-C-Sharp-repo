using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04___Passion_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            string symb = Console.ReadLine();
            decimal cost = 0;
            var purs = 0;
            while (symb != "mall.Enter")
            {
                symb = Console.ReadLine();
            }
            symb = Console.ReadLine();
            while (symb != "mall.Exit")
            {

                foreach (char item in symb)
                {
                    if (item >= 'a' && item <= 'z')
                    {
                        cost = (int)item - ((int)item * 0.70m);
                        if (cost > money)
                        {
                            continue;
                        }
                        money -= cost;
                        purs++;
                    }
                    else if (item >= 'A' && item <= 'Z')
                    {
                        cost = (int)item - ((int)item * 0.50m);
                        if (cost > money)
                        {
                            continue;
                        }
                        money -= cost;
                        purs++;
                    }
                    else if (item == '*')
                    {
                        money += 10;
                    }
                    else if (item == '%')
                    {
                        money /= 2;
                        if (money <= 0)
                        {
                            continue;
                        }
                        purs++;
                    }
                    else
                    {
                        cost = (int)item;
                        if (cost > money)
                        {
                            continue;
                        }
                        money -= cost;
                        purs++;
                    }
                }
                symb = Console.ReadLine();

            }
            if (purs == 0)
            {
                Console.WriteLine($"No purchases. Money left: {money:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{purs} purchases. Money left: {money:f2} lv.");
            }

        }
    }
}
