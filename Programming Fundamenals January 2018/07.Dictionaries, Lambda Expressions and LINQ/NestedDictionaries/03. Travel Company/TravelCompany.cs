using System;
using System.Collections.Generic;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/433#2
/// </summary>

namespace _03._Travel_Company
{
    class TravelCompany
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> travelAgency = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "ready")
            {
                string[] args = input.Split(':');
                string city = args[0];

                if (!travelAgency.ContainsKey(city))
                {
                    travelAgency.Add(city, new Dictionary<string, int>());
                }
                string[] transport = args[1].Split(',');
                foreach (var transportAndPrice in transport)
                {
                    string[] trans = transportAndPrice.Split('-');
                    string vehicleType = trans[0];
                    int capacity = int.Parse(trans[1]);

                    if (!travelAgency[city].ContainsKey(vehicleType))
                    {
                        travelAgency[city].Add(vehicleType, 0);
                    }
                    travelAgency[city][vehicleType] = capacity;
                }
            }

            while ((input = Console.ReadLine()) != "travel time!")
            {
                string[] args = input.Split();
                string queryCity = args[0];
                int passagers = int.Parse(args[1]);

                if (travelAgency.ContainsKey(queryCity))
                {
                    int avalableSeats = 0;

                    foreach (var seats in travelAgency[queryCity])
                    {
                            avalableSeats += seats.Value;
                    }

                    if (avalableSeats > passagers)
                    {
                        Console.WriteLine($"{queryCity} -> all {passagers} accommodated");
                    }
                    else
                    {
                        int seatsNeeded = passagers - avalableSeats;
                        Console.WriteLine($"{queryCity} -> all except {seatsNeeded} accommodated");
                    }
                }


            }
        }
    }
}
