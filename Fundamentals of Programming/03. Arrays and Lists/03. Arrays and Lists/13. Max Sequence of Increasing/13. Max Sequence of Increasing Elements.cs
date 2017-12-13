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
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List <int> resList = new List<int>();
            List<int> compList = new List<int>();


            var count = 1;
            var max = 0;
            

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]<arr[i+1])
                {
                    count++;
                    if (max < count)
                    {
                        resList.Add(arr[i]);
                        resList.Add(arr[i+1]);

                        if (resList[i]== resList.Last())
                        {
                            resList.Remove(arr[i]);
                        }
                    }

                   
                }
                else
                {
                    count = 1;
                    resList.Clear();
                }
            }

            Console.WriteLine(string.Join(" ",resList));
        }
    }
}
