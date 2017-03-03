using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            var lenght = h * 100;
            var widht = w * 100 - 100;

            var rows = Math.Floor(lenght / 120);
            var decksOnRow = Math.Floor(widht / 70);

            var totalSeats = rows * decksOnRow - 3;
            Console.WriteLine(totalSeats);



        }
    }
}
