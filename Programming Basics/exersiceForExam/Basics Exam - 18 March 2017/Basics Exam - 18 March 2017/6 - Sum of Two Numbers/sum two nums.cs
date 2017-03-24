using System;

namespace _6___Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int mag = int.Parse(Console.ReadLine());

            var count = 0;
            bool found = false;
            for (int i = start; i <=end; i++)
            {
                for (int y = start; y <=end; y++)
                {
                    count++;
                    if (i+y==mag)
                    {
                        found = true;
                        Console.WriteLine($"Combination N:{count} ({i} + {y} = {mag})");
                        return;
                    }
                }
            }
            if (found==false)
            {
                Console.WriteLine($"{count} combinations - neither equals {mag}");
            }

        }
    }
}