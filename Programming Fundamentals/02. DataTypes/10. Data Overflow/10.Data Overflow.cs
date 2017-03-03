using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = ulong.Parse(Console.ReadLine());
            var number2 = ulong.Parse(Console.ReadLine());

            ulong biggerNum = Math.Max(number1, number2);
            ulong smallerNum = Math.Min(number1, number2);

            string biggerType = "";
            string smallerType = "";
            ulong smallNumType = 0;

            if (biggerNum>=smallerNum)
            {
                if (biggerNum>=byte.MinValue && biggerNum<=byte.MaxValue)
                {
                    biggerType = "byte";
                }
                else if (biggerNum>=ushort.MinValue&&biggerNum<=ushort.MaxValue)
                {
                    biggerType = "ushort";
                }
                else if (biggerNum>=uint.MinValue&&biggerNum<=uint.MaxValue)
                {
                    biggerType = "uint";
                }
                else if (biggerNum>=ulong.MinValue&&biggerNum<=ulong.MaxValue)
                {
                    biggerType = "ulong";
                }
            }
            if (smallerNum >= byte.MinValue && smallerNum <= byte.MaxValue)
            {
                smallerType = "byte";
                smallNumType = byte.MaxValue;
            }
            else if (smallerNum >= ushort.MinValue && smallerNum <= ushort.MaxValue)
            {
                smallerType = "ushort";
                smallNumType = ushort.MaxValue;
            }
            else if (smallerNum >= uint.MinValue && smallerNum <= uint.MaxValue)
            {
                smallerType = "uint";
                smallNumType = uint.MaxValue;
            }
            else if (biggerNum >= ulong.MinValue && biggerNum <= ulong.MaxValue)
            {
                smallerType = "ulong";
                smallNumType = ulong.MaxValue;
            }
            var res = Math.Round((double)biggerNum / smallNumType);
            Console.WriteLine($"bigger type: {biggerType}\nsmaller type: {smallerType}\n{biggerNum} can overflow {smallerType} {res} times" );

        }
    }
}

