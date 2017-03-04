using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.logis
{
    class logis
    {
        static void Main(string[] args)
        {
            int load = int.Parse(Console.ReadLine());
            decimal bus = 0;
            decimal truck = 0;
            decimal train = 0;
            decimal totalWeight = 0;
            for (int i = 0; i < load; i++)
            {
                int ton = int.Parse(Console.ReadLine());
                if (ton<=3)
                {
                    bus += ton;
                }
                else if (ton>=4&&ton<=11)
                {
                    truck += ton;
                }
                else
                {
                    train += ton;
                }
                totalWeight += ton;
            }
            decimal averange = (bus * 200 + truck * 175 + train * 120) / totalWeight;
            decimal avgBus = bus / totalWeight * 100;
            decimal avgTruck = truck / totalWeight * 100;
            decimal avgTrain = train / totalWeight * 100;
            Console.WriteLine("{0:f2}",averange);
            Console.WriteLine("{0:f2}%",avgBus);
            Console.WriteLine("{0:f2}%",avgTruck);
            Console.WriteLine("{0:f2}%",avgTrain);
        }
    }
}
