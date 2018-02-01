using System;

namespace _12._Master_Number
{
    class MasterNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                if (IsPalidrome(i) && IsSum7(i) && IsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsEvenDigit(int i)
        {
            int lastDigit;
            while (i > 0)
            {
                lastDigit = i % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static bool IsSum7(int i)
        {
            int lastDigit = 0;
            long sum = 0;
            while (i > 0)
            {
                lastDigit = i % 10;
                sum += lastDigit;
                i /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsPalidrome(int i)
        {
            
            for (int i = 0; i < length; i++)
            {

            }

            //for (int j = toText.Length - 1; j >= 0; j--)
            //{
            //    reversed += toText[j];
            //}
            //
            //int textToNum = int.Parse(reversed);
            //
            //if (textToNum == i)
            //{
            //    return true;
            //}
            //
            //return false;

        }
    }
}
