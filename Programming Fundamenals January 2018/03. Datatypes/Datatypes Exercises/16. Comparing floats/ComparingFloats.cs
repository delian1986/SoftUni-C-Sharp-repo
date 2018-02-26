using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double a =double.Parse(Console.ReadLine());
            double b =double.Parse(Console.ReadLine());

            double sub=Math.Abs(a-b);
            string subText=sub.ToString();
            if (sub>0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
