using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourDigits
{
    class fourDigits
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            
            var firstNum = num / 1000;
            var secondNum = num / 100%10;
            var thindNum = num / 10%10;
            var fourNum = num % 10;

            Console.WriteLine(firstNum+secondNum+thindNum+fourNum);
            Console.WriteLine("{0}{1}{2}{3}",fourNum,thindNum,secondNum,firstNum);
            Console.WriteLine("{0}{1}{2}{3}",fourNum,firstNum,secondNum,thindNum);
            Console.WriteLine("{0}{1}{2}{3}",firstNum,thindNum,secondNum,fourNum);
        }
    }
}
