using System;
using System.Linq;

namespace _02._Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]sequence=Console.ReadLine().Split().ToArray();

            int sum=0;
            int countOfLetters=0;

            foreach (var word in sequence)
            {
                foreach (var letter in word)
                {
                    sum+=letter;
                    countOfLetters++;
                }
            }

            int avgSumOfSequence=sum/countOfLetters;
            string delimiter=((char)avgSumOfSequence).ToString();
            


            Console.WriteLine(string.Join($"{delimiter.ToUpper()}",sequence));
        }
    }
}
