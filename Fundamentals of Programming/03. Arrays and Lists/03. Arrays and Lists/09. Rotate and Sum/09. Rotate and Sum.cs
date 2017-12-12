using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());

            List<int> impList = new List<int>();


            List<int> myList = new List<int>();

            for (int i = 0; i < num; i++)
            {
                int temp = inputList[inputList.Count - 1];
                for (int j = inputList.Count-1; j >=1; j++)
                {
                    inputList[j] = inputList[j - 1];
                }
                inputList[0] = temp;
            }


        }
    }
}
