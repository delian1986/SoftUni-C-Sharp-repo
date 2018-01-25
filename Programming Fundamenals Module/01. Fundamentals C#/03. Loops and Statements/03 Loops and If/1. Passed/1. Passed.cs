using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Random r = new Random();
            string[] result = new string[]
            {
                "Passed!",
                "Failed"
            };

            int number = r.Next(0, 1);

            Console.WriteLine(result[number]);
        }
    }
}
