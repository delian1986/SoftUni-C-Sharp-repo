using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Max_Sequence_of_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputLine = Console.ReadLine().Split().Select(long.Parse).ToArray();
            List<long> nums = new List<long>();
            List<long> temp = new List<long>();
            List<long> left = new List<long>();
            var count = 0;

            for (int i = 0; i < inputLine.Length - 1; i++)
            {
                if (inputLine[i] < inputLine[i + 1])
                {
                    nums.Add(inputLine[i]);
                    nums.Add(inputLine[i + 1]);
                    if (nums.Count > 2 && nums.Contains(inputLine[i]))
                    {
                        nums.Remove(inputLine[i]);
                    }
                    if (count==0)
                    {
                        left = nums;

                    }
                }
                if (inputLine[i] >= inputLine[i + 1])
                {
                    if (nums.Count >= temp.Count)
                    {
                        count++;
                        temp = nums;
                        nums = new List<long>();



                    }
                }
            }

            if (nums.Count>temp.Count)
            {

            Console.WriteLine(string.Join(" ", nums));
            }
            else if (temp.Count==left.Count||left.Count>temp.Count||left.Count==nums.Count)
            {
                Console.WriteLine(string.Join(" ", left));

            }
            else
            {
                Console.WriteLine(string.Join(" ", temp));

            }
        }
    }
}
