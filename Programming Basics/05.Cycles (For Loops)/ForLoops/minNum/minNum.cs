using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minNum
{
    class minNum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int MinVal = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers<MinVal)
                {
                    MinVal=+numbers;
                }
                
            }
            Console.WriteLine(MinVal);
        }
    }
}
