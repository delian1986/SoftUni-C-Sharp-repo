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

            var commnad = String.Empty;

            while (commnad != "print")
            {
                commnad = Console.ReadLine().ToLower();
                string output = Regex.Match(commnad, @"\d+").Value;

                if (commnad == "add" && commnad == "addmany")
                {

                }
            }
        }
    }
}
