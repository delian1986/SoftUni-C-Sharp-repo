using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            if (dayTime == "night" && n < 20)
            {
                Console.WriteLine(0.70 + n * 0.90);
            }
            if (n < 20 && dayTime == "day")
            {
                Console.WriteLine(0.70 + n * 0.79);
            }
            if (n >= 20 && n < 100)
            {
                Console.WriteLine(n * 0.09);
            }
            if (n >= 100)
            {
                Console.WriteLine(n * 0.06);
            }
        }
    }
}
