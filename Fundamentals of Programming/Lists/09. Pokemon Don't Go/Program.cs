using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> catchedPokoemns = new List<int>();

            while (true)
            {

                if (input.Count()==0)
                {
                    break;
                }

                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int firstElement = input[0];
                    int lastElement = input[input.Count() - 1];
                    catchedPokoemns.Add(firstElement);
                    input[0] = lastElement;

                    increseDecrece(input, firstElement);
                }
                else if (index>input.Count()-1)
                {
                    catchedPokoemns.Add(input[input.Count() - 1]);
                    int firstElement = input[0];
                    input[input.Count() - 1] = firstElement;

                    increseDecrece(input, input[input.Count() - 1]);

                }
                else
                {
                    int element = input[index];
                    catchedPokoemns.Add(element);
                    input.RemoveAt(index);
                    increseDecrece(input, element);
                }
            }

            Console.WriteLine(catchedPokoemns.Sum());

        }

        private static void increseDecrece(List<int> input, int firstElement)
        {
            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i] <= firstElement)
                {
                    input[i] += firstElement;
                }
                else
                {
                    input[i] -= firstElement;
                }
            }
        }

    }
}
