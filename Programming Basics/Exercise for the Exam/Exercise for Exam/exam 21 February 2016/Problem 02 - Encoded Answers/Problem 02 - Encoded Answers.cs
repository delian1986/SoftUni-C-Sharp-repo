using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02___Encoded_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = uint.Parse(Console.ReadLine());
            PrintResult(n);
        }

        private static void PrintResult(uint n)
        {
            string answer = String.Empty;
            var counterA = 0;
            var counterB = 0;
            var counterC = 0;
            var counterD = 0;

            for (int i = 0; i < n; i++)
            {
                var num = uint.Parse(Console.ReadLine());

                if (num % 4 == 0)
                {
                    answer += "a ";
                    counterA++;
                }
                else if (num % 4 == 1)
                {
                    answer += "b ";
                    counterB++;
                }
                else if (num % 4 == 2)
                {
                    answer += "c ";
                    counterC++;
                }
                else if (num % 4 == 3)
                {
                    answer += "d ";
                    counterD++;
                }

            }
            Console.WriteLine($"{answer}\nAnswer A: {counterA}\nAnswer B: {counterB}\nAnswer C: {counterC}\nAnswer D: {counterD}");
        }

    }
}

