using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CenterPodouble
{
    static void Main()
    {
        double x1Input = double.Parse(Console.ReadLine());
        double y1Input = double.Parse(Console.ReadLine());
        double x2Input = double.Parse(Console.ReadLine());
        double y2Input = double.Parse(Console.ReadLine());

        var x1 = Math.Abs(x1Input);
        var y1 = Math.Abs(y1Input);
        var x2 = Math.Abs(x2Input);
        var y2 = Math.Abs(y2Input);



        if (x1<=x2&&y1<=y2)
        {
            Console.WriteLine($"({x1Input}, {y1Input})");
        }
        else
        {
            Console.WriteLine($"({x2Input}, {y2Input})");

        }

    }
}
