using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.battle
{
    class battle
    {
        static void Main(string[] args)
        {
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            int bttl = int.Parse(Console.ReadLine());
            var bttlStop = 1;

            for (int i = 1; i <= p1; i++)
            {
                for (int j = 1; j <= p2; j++)
                {
                    if (bttlStop>bttl)
                    {
                        return;
                    }
                    Console.Write("({0} <-> {1}) ",i,j);
                    bttlStop++;
                }
            }

        }
    }
}
