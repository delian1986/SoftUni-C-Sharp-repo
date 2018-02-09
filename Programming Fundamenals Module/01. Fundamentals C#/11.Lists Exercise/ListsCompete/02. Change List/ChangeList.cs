using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string []command=Console.ReadLine().Split();
            while (true)
            {
                if (command[0]=="Odd"||command[0]=="Even")
                {
                    break;
                }
                string action=command[0];
                if (action=="Delete")
                {
                    int numToRemove=int.Parse(command[1]);
                    nums.RemoveAll(x=>x==numToRemove);
                }
                else if (action=="Insert")
                {
                    int element=int.Parse(command[1]);
                    int toPosition=int.Parse(command[2]);

                    nums.Insert(toPosition,element);
                }

                command=Console.ReadLine().Split();
            }
            if (command[0]=="Even")
            {
                var evenList=nums.Where(x=>x%2==0);
                Console.WriteLine(string.Join(" ",evenList));
            }
            else
            {
                var oddList=nums.Where(x=>x%2!=0);
                Console.WriteLine(string.Join(" ",oddList));
            }


        }
    }
}
