using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputLine1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] inputLine2 = Console.ReadLine().Split().Select(char.Parse).ToArray();


            if (inputLine1.Length != inputLine2.Length)
            {
                int counter = 0;

                for (int i = 0; i < Math.Min(inputLine1.Length, inputLine2.Length); i++)
                {
                    if (inputLine1[i] < inputLine2[i])
                    {
                        FirstInputIsSmaller(inputLine1, inputLine2);
                        return;

                    }
                    else if (inputLine1[i] > inputLine2[i])
                    {
                        SecondInputIsSmaller(inputLine1, inputLine2);
                        return;

                    }
                    else
                    {
                        counter++;
                    }
                }
                if (counter == inputLine1.Length)
                {
                    FirstInputIsSmaller(inputLine1, inputLine2);
                    return;

                }
                else
                {
                    SecondInputIsSmaller(inputLine1, inputLine2);
                    return;

                }
            }
            else
            {
                for (int i = 0; i < inputLine1.Length; i++)
                {
                    if (inputLine1[i] < inputLine2[i])
                    {
                        FirstInputIsSmaller(inputLine1, inputLine2);
                        return;

                    }
                    else if (inputLine1[i] > inputLine2[i])
                    {
                        SecondInputIsSmaller(inputLine1, inputLine2);
                        return;

                    }
                    else
                    {
                        FirstInputIsSmaller(inputLine1, inputLine2);
                        return;
                    }
                }
            }
        }

        private static void SecondInputIsSmaller(char[] inputLine1, char[] inputLine2)
        {
            Console.WriteLine(string.Join("", inputLine2));
            Console.WriteLine(string.Join("", inputLine1));
        }

        private static void FirstInputIsSmaller(char[] inputLine1, char[] inputLine2)
        {
            Console.WriteLine(string.Join("", inputLine1));
            Console.WriteLine(string.Join("", inputLine2));
        }
    }
}
