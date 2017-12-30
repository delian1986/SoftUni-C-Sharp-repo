using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MasterNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> masterNum = new List<int>();

        for (int i = 5; i <= n; i++)
        {
            //int i = 232;
            bool pali=Palidrome(i);
            bool sumOfDigits = SumOfDigits(i);
            bool oneEven = EvenDigit(i);
            if (pali&&sumOfDigits&&oneEven)
            {
                masterNum.Add(i);
            }
        }
        foreach (var item in masterNum)
        {
            Console.WriteLine(item);
        }
    }

    private static bool EvenDigit(int i)
    {
        var arrI = i.ToString();
        foreach (var num in arrI)
        {
            if ((num-48)%2==0)
            {
                return true;
            }
        }
            return false;
    }

    private static bool SumOfDigits(int i)
    {
        var arrI = i.ToString();
        var sum = 0;
        foreach (var num in arrI)
        {
            sum += num-48;
        }
        if (sum%7==0)
        {
            return true;
        }
        return false;
    }

    private static bool Palidrome(int i)
    {
        int reminder, temp,reverse = 0;
        temp = i;
        while (i>0)
        {
            reminder = i % 10;
            reverse = reverse * 10 + reminder;
            i /= 10;
        }
        if (temp==reverse)
        {
            return true;
        }
        return false;
    }
}

