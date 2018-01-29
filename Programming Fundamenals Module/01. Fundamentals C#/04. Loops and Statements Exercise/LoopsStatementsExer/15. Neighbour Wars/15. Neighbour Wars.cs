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
            int roundOfTheGame = 0;
            int restoreHpCount = 1;


            while (peshoHP >= 0 || goshoHP >= 0)
            {
                roundOfTheGame++;

                if (roundOfTheGame % 2 == 0)
                {
                    peshoHP -= goshoDmg;
                    if (peshoHP<=0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHP} health.");
                }
                else
                {
                    goshoHP -= peshoDmg;
                    if (goshoHP<=0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHP} health.");
                }
                if (restoreHpCount == 3)
                {
                    goshoHP += 10;
                    peshoHP += 10;
                    restoreHpCount=0;
                }
                restoreHpCount++;
            }

            string winner;
            if (roundOfTheGame%2==0)
            {
                winner="Gosho";
            }
            else
            {
                winner="Pesho";
            }

            Console.WriteLine($"{winner} won in {roundOfTheGame}th round.");
        }

    }
}
