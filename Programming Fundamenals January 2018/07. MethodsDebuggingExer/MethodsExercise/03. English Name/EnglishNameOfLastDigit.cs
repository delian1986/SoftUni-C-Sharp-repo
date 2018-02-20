using System;

namespace _03._English_Name
{
    class EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));

            long lastDigit = FindLastDigit(number);
            string digitToWord = ConvertFromDigitToWord(lastDigit);
            Console.WriteLine(digitToWord);

        }

        private static string ConvertFromDigitToWord(long lastDigit)
        {
            string word = string.Empty;
            switch (lastDigit)
            {
                case 1:
                    word = "one";
                    break;
                case 2:
                    word = "two";
                    break;
                case 3:
                    word = "three";
                    break;
                case 4:
                    word = "four";
                    break;
                case 5:
                    word = "five";
                    break;
                case 6:
                    word = "six";
                    break;
                case 7:
                    word = "seven";
                    break;
                case 8:
                    word = "eight";
                    break;
                case 9:
                    word = "nine";
                    break;

                case 0:
                    word = "zero";
                    break;
            }
            return word;
        }

        private static long FindLastDigit(long number)
        {
            long num = number % 10;
            return num;
        }
    }
}
