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

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "print")
            {

                if (command[0] == "add" && command[0] == "addmany")
                {
                    myList.Insert(command[1], command[2]);
                }
            }
        }
    }
}
