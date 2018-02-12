using System;
using System.Collections.Generic;
using System.Linq;


namespace _01._Shoot_List_Elements
{
    class ShootListElements
    {
        static void Main(string[] args)
        {
            string inputLine = string.Empty;
            List<int> shootMeList = new List<int>();
            int lastShooted = int.MinValue;

            while ((inputLine = Console.ReadLine()) != "stop")
            {
                if (inputLine == "bang")
                {
                    if (shootMeList.Count == 1)
                    {
                        lastShooted = shootMeList[0];
                        shootMeList.Remove(shootMeList[0]);
                        PrintShootElement(lastShooted);
                    }
                    else if (shootMeList.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastShooted}");
                        break;
                    }
                    else
                    {
                        double avgVal = shootMeList.Average();
                        lastShooted = RemoveSmallerThanAverange(avgVal, shootMeList, lastShooted);
                        shootMeList = DecrementingAllByOne(shootMeList);

                    }

                }
                else
                {
                    shootMeList.Insert(0, int.Parse(inputLine));
                }
            }

            if (shootMeList.Count==0&&inputLine=="stop")
            {
                Console.WriteLine($"you shot them all. last one was {lastShooted}");
            }
            else if (shootMeList.Count!=0&&inputLine=="stop")
            {
                Console.WriteLine($"survivors: {string.Join(" ",shootMeList)}");
            }
        }

        private static void PrintShootElement(int lastShooted)
        {
            Console.WriteLine($"shot {lastShooted}");

        }

        private static List<int> DecrementingAllByOne(List<int> shootMeList)
        {
            for (int i = 0; i < shootMeList.Count; i++)
            {
                shootMeList[i] -= 1;
            }
            return shootMeList;
        }

        private static int RemoveSmallerThanAverange(double avgVal, List<int> shootMeList, int lastShooted)
        {
            for (int i = 0; i < shootMeList.Count; i++)
            {
                if (shootMeList[i] < avgVal)
                {
                    lastShooted = shootMeList[i];
                    shootMeList.Remove(shootMeList[i]);
                    PrintShootElement(lastShooted);

                    break;
                }
            }
            return lastShooted;
        }
    }
}
