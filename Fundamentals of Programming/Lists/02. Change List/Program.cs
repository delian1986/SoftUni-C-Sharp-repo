using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string line = null;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] cmd = line.Split(" ");

                if (cmd[0]=="Delete")
                {

                    list.RemoveAll(i=>i==int.Parse(cmd[1]));

                }
                else
                {
                    list.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                }
            }

            Console.WriteLine(string.Join(" ", list));


        }
    }
}
