using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            int seats = rows * column;
            if (typeOfMovie == "Premiere")
            {
                decimal price = seats * 12.00M;
                Console.WriteLine("{0:F2} leva", price);

            }
            else if (typeOfMovie == "Normal")
            {
                decimal price = seats * 7.50M;
                Console.WriteLine("{0:F2} leva", price);
            }
            else if (typeOfMovie == "Discount")
            {
                decimal price = seats * 5.00M;
                Console.WriteLine("{0:F2} leva", price);
            }
        }
    }
}
