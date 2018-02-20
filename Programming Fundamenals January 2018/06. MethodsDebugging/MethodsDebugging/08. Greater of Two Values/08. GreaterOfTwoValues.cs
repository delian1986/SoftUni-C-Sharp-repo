using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GreaterOfTwo
{
    static void Main()
    {
        string dataType = Console.ReadLine();

        string result = string.Empty;
        if (dataType == "int")
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int biggerInt = GetMax(firstNum, secondNum);
            result = biggerInt.ToString();
        }
        else if (dataType == "char")
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            char biggerChar = GetMax(firstChar, secondChar);
            result = biggerChar.ToString();
        }
        else
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            result = GetMax(firstString, secondString);
        }

        Console.WriteLine(result);

    }

    private static string GetMax(string firstString, string secondString)
    {
        int bigger = firstString.CompareTo(secondString);
        if (bigger <= 0)
        {
            return secondString;
        }
        else
        {
            return firstString;
        }
    }

    static char GetMax(char firstChar, char secondChar)
    {
        if (firstChar >= secondChar)
        {
            return firstChar;
        }
        else
        {
            return secondChar;
        }
    }

    static int GetMax(int firstNum, int secondNum)
    {
        return Math.Max(firstNum, secondNum);
    }


}
