using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
           
            var year = 1914;
            DateTime input = new DateTime(year, month, day);
            DateTime res = input.AddDays(5);
            Console.WriteLine(res.ToString("d.MM"));

        }
    }
}
