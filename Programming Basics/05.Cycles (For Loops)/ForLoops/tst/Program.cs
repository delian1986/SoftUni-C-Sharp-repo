using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tst
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter %2==0)
            {
                Console.WriteLine(counter);
                counter ++;
            }
        }
    }
}
