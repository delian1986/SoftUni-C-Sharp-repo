using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2_RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            var random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var currentWord = input[i];
                var randomWord = random.Next(0, input.Length);

                var tempWord = input[randomWord];
                input[i] = tempWord;
                input[randomWord]= currentWord;
            }
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
