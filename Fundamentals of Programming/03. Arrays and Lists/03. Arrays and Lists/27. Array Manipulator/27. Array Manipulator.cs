using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _27.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();

            var command = Console.ReadLine().ToLower().Split();

            while (command[0] != "print")
            {
                List<int> nums = new List<int>();

                //parse the nums as numbers
                for (int i = 1; i < command.Length; i++)
                {
                    nums.Add(int.Parse(command[i]));

                }

                //if - else if logic
                if (command[0] == "add")
                {
                    myList.Insert(nums[0], nums[1]);
                }

                else if (command[0] == "addmany")
                {

                    myList.InsertRange(nums[0], nums.Skip(1));
                    

                }

                else if (command[0] == "contains")
                {
                    if (myList.Contains(nums[0]))
                    {
                        for (int i = 0; i < myList.Count; i++)
                        {
                            if (nums[0] == myList[i])
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }

                else if (command[0] == "remove")
                {
                    myList.RemoveAt(nums[0]);
                }

                else if (command[0] == "shift")
                {
                    for (int i = 0; i < nums[0]; i++)
                    {
                        int first = myList[0];
                        int last = myList.Last();
                        for (int j = 0; j < myList.Count - 1; j++)
                        {
                            myList[j] = myList[j + 1];
                        }
                        myList[myList.Count - 1] = first;
                    }
                }

                else if (command[0] == "sumpairs")
                {
                    for (int i = 0; i < myList.Count - 1; i++)
                    {
                        {
                            myList[i] = myList[i] + myList[i + 1];
                            myList.Remove(myList[i + 1]);

                        }
                    }
                }

                //input
                command = Console.ReadLine().ToLower().Split();

            }

            Console.Write("[");
            Console.Write(string.Join(", ", myList));
            Console.WriteLine("]");
        }
    }
}
