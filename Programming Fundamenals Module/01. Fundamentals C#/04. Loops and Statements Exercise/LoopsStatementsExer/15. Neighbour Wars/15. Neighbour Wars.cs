using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            int peshoHP = 100;
            int goshoHP = 100;
            int count = 0;

            while (peshoHP>=0||goshoHP>=0)
            {
                goshoHP -= peshoDmg;
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHP} health.");
                count++;

                peshoHP -= goshoDmg;
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {goshoHP} health.");
                count++;
                
            }
            int winner = Math.Max(goshoHP, peshoHP);

            Console.WriteLine($"{count}");
        }
    }
}
