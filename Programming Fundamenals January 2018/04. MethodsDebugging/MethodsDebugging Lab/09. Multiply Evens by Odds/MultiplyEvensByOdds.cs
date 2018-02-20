using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens_by_Odds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number=Math.Abs(int.Parse(Console.ReadLine()));
            int result=GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvensAndOdds(int number)
        {
            int multipleOddsAndEvens=SumOfDigits(number);
            return multipleOddsAndEvens;
        }

        private static int SumOfOdds(int number,int digit)
        {
            int sumOfOdds=0;
            return sumOfOdds+=digit;

        }

        private static int SumOfDigits(int number)
        {
            int sumOfEvens=0;
            int sumOfOdds=0;
            while (number>0)
            {
                int digit=number%10;
                if (digit%2==0)
                {
                    sumOfEvens+=digit;
                }
                else
                {
                    sumOfOdds+=SumOfOdds(number,digit);
                }
                number/=10;
            }
            return sumOfEvens*sumOfOdds;
            
        }
    }
}
