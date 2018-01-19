using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split().Select(s => long.Parse(s)).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(s => long.Parse(s)).ToList();


            for (int i = 0; i < beehives.Count; i++)
            {

                if (hornets.Count <= 0)
                {
                    break;
                }

                if (hornets.Sum() > beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else
                {
                    beehives[i] -= hornets.Sum();

                    hornets.RemoveAt(0);
                }
            }
            if (beehives.Where(h=>h>0).ToList().Count()>0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b=>b>0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));

            }
        }
    }
}
