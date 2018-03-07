using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            var ppl = int.Parse(Console.ReadLine());

            var res = Math.Ceiling((decimal)ppl / 24);
            Console.WriteLine(res);
        }
    }
}
