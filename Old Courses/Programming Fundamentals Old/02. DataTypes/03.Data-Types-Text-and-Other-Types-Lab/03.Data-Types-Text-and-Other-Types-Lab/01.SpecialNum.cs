using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Data_Types_Text_and_Other_Types_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                var currNum = i;
                var sum = 0;
                foreach (var item in currNum.ToString())
                {
                    var digit = item - '0';
                    sum += digit;
                }
                var res = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {res}");
            }
            
        }
    }
}
