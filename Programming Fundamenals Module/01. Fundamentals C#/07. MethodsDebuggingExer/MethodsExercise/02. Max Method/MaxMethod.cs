using System;

namespace _02._Max_Method
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int firstNum=int.Parse(Console.ReadLine());
            int secondNum=int.Parse(Console.ReadLine());
            int thirdNum=int.Parse(Console.ReadLine());

            int biggestNum=FindBiggestNum(firstNum,secondNum,thirdNum);
            Console.WriteLine(biggestNum);
        }

        private static int FindBiggestNum(int firstNum, int secondNum, int thirdNum)
        {
            int bigger=Math.Max(firstNum,secondNum);
            int biggest=Math.Max(bigger,thirdNum);

            return biggest;
        }
    }
}
