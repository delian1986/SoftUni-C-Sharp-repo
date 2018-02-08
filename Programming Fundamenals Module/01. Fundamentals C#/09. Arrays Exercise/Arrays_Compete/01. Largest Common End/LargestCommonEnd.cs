using System;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string[] setence = Console.ReadLine().Split();

            int startCounter=0;
            int endCounter=0;

            for (int i = 0; i < Math.Min(words.Length,setence.Length); i++)
            {
                if (words[i]==setence[i])
                {
                    startCounter++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < Math.Min(words.Length,setence.Length); i++)
            {
                if (words[words.Length-1-i]==setence[setence.Length-1-i])
                {
                    endCounter++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(startCounter,endCounter));
        }

    }
}
