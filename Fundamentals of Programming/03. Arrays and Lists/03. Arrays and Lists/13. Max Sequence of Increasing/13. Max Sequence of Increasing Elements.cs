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
            List<int> resList = new List<int>();
            List<int> tempList = new List<int>();


            var count = 1;
            var max = 0;


            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    count++;
                    if (max < count)
                    {
                        resList.Add(arr[i]);
                        resList.Add(arr[i+1]);
                        for (int j = 0; j <resList.Count-1; j++)
                        {
                            if (resList[j]==resList[j+1])
                            {
                                resList.Remove(resList[j]);
                            }
                        }
                        tempList = resList;
                    }
                    else if (arr[i]>arr[i+1])
                    {
                        tempList.Add(arr[i]);
                        tempList.Add(arr[i + 1]);
                        for (int j = 0; j < resList.Count - 1; j++)
                        {
                            if (tempList[j] == tempList[j + 1])
                            {
                                resList.Remove(resList[j]);
                            }
                        }
                    }


                }
                else
                {
                    count = 1;
                    //resList.Clear();
                }
            }

            Console.WriteLine(string.Join(" ", resList));
        }
    }
}
