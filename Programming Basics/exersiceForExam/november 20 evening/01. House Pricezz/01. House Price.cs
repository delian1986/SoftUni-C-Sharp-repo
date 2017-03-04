using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Pricezz
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal smallRoom = decimal.Parse(Console.ReadLine());
            decimal kitchen = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal bath = smallRoom * 0.50m;
            decimal room = smallRoom + (smallRoom * 0.10m);
            decimal trdRoom = room + (room * 0.10m);
            decimal area = bath + room + trdRoom + smallRoom+kitchen;
            decimal totArea = area + (area * 0.05m);
            Console.WriteLine("{0:f2}", totArea * price);
          
        }
    }
}
