using System;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isFound = false;

            for (int a = 0; a < elements.Length; a++)
            {
                for (int b = a + 1; b < elements.Length; b++)
                {
                    int sum = elements[a] + elements[b];
                    if (elements.Contains(sum))
                    {
                        Console.WriteLine($"{elements[a]} + {elements[b]} == {sum}");
                        isFound = true;

                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
