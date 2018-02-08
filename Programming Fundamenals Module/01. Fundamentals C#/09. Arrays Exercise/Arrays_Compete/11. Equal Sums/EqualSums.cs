using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isFound=false;

            for (int i = 0; i < elements.Length; i++)
            {
                int []firstPart=elements.Take(i).ToArray();
                int[] secondPart=elements.Skip(i+1).ToArray();

                if (firstPart.Sum()==secondPart.Sum())
                {
                    Console.WriteLine(i);
                    isFound=true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
