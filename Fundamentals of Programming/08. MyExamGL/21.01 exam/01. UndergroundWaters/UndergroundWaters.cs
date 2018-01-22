using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.UndergroundWaters
{
    class UndergroundWaters
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            List<int> air = new List<int>();
            List<int> rain = new List<int>();
            List<int> airLocalMax = new List<int>();

            int airMax = 0;
            int rainMax = 0;

            if (input1.Length != 0)
            {
                air = input1.Split()
                    .Select(int.Parse).ToList();
            }

            if (input2.Length != 0)
            {
                rain = input2.Split().Select(int.Parse).ToList();
            }

            airLocalMax = FindLocalAirMax(air, airMax, airLocalMax);

            rain = SubstractMaxCount(airLocalMax, rain);

            airMax = FindLocalMaxValue(airLocalMax, airMax);
            rainMax= FindLocalMaxRainValue(rain, rainMax);
        }

        private static int FindLocalMaxRainValue(List<int> rain, int rainMax)
        {
            if (rain.Count == 1 || rain.Count == 0)
            {
                rainMax = 0;
            }

            else
            {
                int temp = int.MinValue;

                for (int i = 0; i < rain.Count - 1; i++)
                {


                    if (i == 0 && rain[i] > rain[i + 1])
                    {
                        temp = rain[i];


                    }

                    else if (i > 0 && rain[i] > rain[i - 1] && rain[i] > rain[i + 1])
                    {
                        temp = rain[i];
                    }

                    else if (rain[rain.Count - 1] > rain[rain.Count - 2])
                    {
                        temp = rain[rain.Count - 1];

                    }
                    if (rainMax < temp)
                    {
                        rainMax = temp;
                    }

                }
            }

            return rainMax;
        }

        private static int FindLocalMaxValue(List<int> airLocalMax, int airMax)
        {
            if (airLocalMax.Count == 1 || airLocalMax.Count == 0)
            {
                airMax = 0;
            }

            else
            {
                int temp = int.MinValue;

                for (int i = 0; i < airLocalMax.Count - 1; i++)
                {


                    if (i == 0 && airLocalMax[i] > airLocalMax[i + 1])
                    {
                        temp = airLocalMax[i];


                    }

                    else if (i > 0 && airLocalMax[i] > airLocalMax[i - 1] && airLocalMax[i] > airLocalMax[i + 1])
                    {
                        temp = airLocalMax[i];
                    }

                    else if (airLocalMax[airLocalMax.Count-1]>airLocalMax[airLocalMax.Count-2])
                    {
                        temp = airLocalMax[airLocalMax.Count-1];

                    }
                    if (airMax < temp)
                    {
                        airMax = temp;
                    }

                }
            }

            return airMax;
        }

        private static List<int> SubstractMaxCount(List<int> airLocalMax, List<int> rain)
        {
            for (int i = 0; i < rain.Count; i++)
            {
                rain[i] -= airLocalMax.Count;
                if (rain[i] <= 0)
                {
                    rain.Remove(rain[i]);
                    i--;
                }
            }

            return rain;
        }



        private static List<int> FindLocalAirMax(List<int> air, int airMax, List<int> airLocalMax)
        {
            if (air.Count == 1)
            {
                airLocalMax.Add(air[0]);
            }
            else
            {
                for (int i = 0; i < air.Count - 1; i++)
                {
                    if (i == 0 && air[i] > air[i + 1])
                    {
                        airLocalMax.Add(air[i]);
                        continue;
                    }

                    if (i > 0 && air[i] > air[i - 1] && air[i] > air[i + 1])
                    {
                        airLocalMax.Add(air[i]);
                    }

                    else if (i == air.Count - 2 && air[air.Count - 1] > air[air.Count - 2])
                    {
                        airLocalMax.Add(air[i + 1]);
                    }
                }
            }
            return airLocalMax;
        }
    }
}
