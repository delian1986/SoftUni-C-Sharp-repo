using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointOnSegment
{
    class pointOnSegment
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());

            var res1 = Math.Abs(num1 - p);
            var res2 = Math.Abs(num2 - p);

            if (p <= num1 && p >= num2||p>=num1&&p<=num2)
            {
                Console.WriteLine("in");
                Console.WriteLine(Math.Min(res1,res2));
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(Math.Min(res1, res2));

            }

        }
    }
}
