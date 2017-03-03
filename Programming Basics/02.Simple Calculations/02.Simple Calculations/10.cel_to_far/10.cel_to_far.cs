using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.cel_to_far
{
    class cel_to_far
    {
        static void Main(string[] args)
        {
            double cel = double.Parse(Console.ReadLine());
            double res = (cel * 1.8) + 32;
            Console.WriteLine("Far = {0}",res );
        }
    }
}
