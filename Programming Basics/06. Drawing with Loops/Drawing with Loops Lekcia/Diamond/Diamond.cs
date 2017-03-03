using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var outside = (n - 1) / 2;

          ///  if (n==1)
          ///  {
          ///      Console.WriteLine("*");
          ///  }
          ///  else if (n==2)
          ///  {
          ///      Console.WriteLine("**");
          ///  }
            //top
            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.Write(new string('-', outside));
                Console.Write("*");
                var mid = n - 2 * outside - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', outside));
                outside--;
            }
            for (int i = 0; i <= (n-1 ) / 2; i++)
            {
                Console.Write(new string('-', outside));
                Console.Write("*");
                var mid = n - 2 * outside - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', outside));
                outside++;

            }
        }
    }
}
