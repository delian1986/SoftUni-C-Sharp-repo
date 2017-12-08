using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Area_of_Figures
{
    class area
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            var result = 0d;

            if (figure=="square")
            {
                var a = double.Parse(Console.ReadLine());
                result = a * a;

            }
            else if (figure== "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                result = a * b;
            }
            else if (figure== "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                result = Math.PI * radius * radius;
            }
            else if (figure=="triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                result = a *h/2;
            }

            Console.WriteLine(Math.Round(result,3));
        }
    }
}
