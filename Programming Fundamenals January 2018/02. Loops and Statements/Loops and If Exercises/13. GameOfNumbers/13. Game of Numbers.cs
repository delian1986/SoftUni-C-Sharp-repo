using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            bool isFound = false;
            int counter = 0;

            for (int i = firstNum; i <= secNum; i++)
            {
                for (int j = firstNum; j <= secNum; j++)
                {
                    counter++;
                    if (i+j==magicNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicNum}");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
