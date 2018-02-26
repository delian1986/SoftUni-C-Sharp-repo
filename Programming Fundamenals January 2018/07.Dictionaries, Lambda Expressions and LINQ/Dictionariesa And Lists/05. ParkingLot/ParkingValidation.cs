using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/// <summary>
/// This program simulate parking. It checks for valid registrations and collect the data.
/// https://judge.softuni.bg/Contests/Practice/Index/582#4
/// </summary>

namespace _05._ParkingLot
{
    class ParkingValidation
    {
        static void Main()
        {
            //Here the program keeps car the owner and car registration.
            Dictionary<string, string> parking = new Dictionary<string, string>();

            int numberOfValidations = int.Parse(Console.ReadLine());

            //The pattern for valid registrations.
            string pattern = @"([A-Z]{2})([0-9]{4})([A-Z]{2})";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < numberOfValidations; i++)
            {
                string[] currentCar = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //Register or Unregister.
                string operation = currentCar[0];
                //Car owner.
                string owner = currentCar[1];

                if (operation == "register")
                {
                    string carNumber = currentCar[2];

                    if (parking.ContainsKey(owner))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[owner]}");
                    }
                    else if (!regex.IsMatch(carNumber))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {carNumber}");
                    }
                    else if (parking.ContainsValue(carNumber))
                    {
                        Console.WriteLine($"ERROR: license plate {carNumber} is busy");
                    }
                    else
                    {
                        parking.Add(owner, carNumber);
                        Console.WriteLine($"{owner} registered {carNumber} successfully");
                    }
                }
                else
                {
                    if (!parking.ContainsKey(owner))
                    {
                        Console.WriteLine($"ERROR: user {owner} not found");
                    }
                    else
                    {
                        parking.Remove(owner);
                        Console.WriteLine($"user {owner} unregistered successfully");
                    }
                }
            }

            foreach (var car in parking)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
