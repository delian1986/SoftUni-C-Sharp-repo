using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();

            List<string> result = new List<string>().ToList();

            foreach (var item in input)
            {
                List<string> nums = item.Split().ToList();
                nums.Reverse();

                foreach (var number in nums)
                {
                    if (number!="")
                    {
                        result.Insert(0, number);
                    }
                }
            }




            Console.WriteLine(string.Join(" ", result));
        }
    }
}
