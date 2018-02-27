using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/691#1
/// 100/100
/// </summary>

namespace _02._Pokemon_Dont_Go
{
    class PokemonDontGo
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int
                .Parse).ToList();

            long sum = 0;
            int element = 0;

            while (sequence.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                //If index is smaller than 0 we make first element equal to last.
                if (index < 0)
                {
                    element=sequence[0];
                    sequence[0] = sequence[sequence.Count - 1];
                }
                //If index is greater than sequence we make 
                else if (index >= sequence.Count)
                {
                    element=sequence[sequence.Count-1];
                    sequence[sequence.Count - 1] = sequence[0];
                }
                
                else
                {
                    //Remove index.
                    element = sequence[index];
                    sequence.RemoveAt(index);
                }

                //Take the sum.
                sum += element;


                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= element)
                    {
                        sequence[i] += element;
                    }
                    else
                    {
                        sequence[i] -= element;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
