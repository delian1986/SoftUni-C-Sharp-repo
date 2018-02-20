using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CounTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count = 0;

            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
