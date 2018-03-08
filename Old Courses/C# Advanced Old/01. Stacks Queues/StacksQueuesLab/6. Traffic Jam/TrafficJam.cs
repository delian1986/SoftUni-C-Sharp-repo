using System;
using System.Collections.Generic;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/925#5
/// Cars enqueue to crossroad. Traffic Light can pass only N (carsToPass). Play with Queue.
/// </summary>

namespace _6._Traffic_Jam
{
    class TrafficJam
    {
        static void Main()
        {
            int carsToPass = int.Parse(Console.ReadLine());
            string trafficLight = string.Empty;
            Queue<string> cars = new Queue<string>();
            int passedCars=0;

            while ((trafficLight = Console.ReadLine()) != "end")
            {
                if (trafficLight == "green")
                {
                    if (carsToPass>cars.Count)
                    {
                        carsToPass=cars.Count;
                    }
                    for (int i = 0; i < carsToPass; i++)
                    {
                        Console.WriteLine("{0} passed!",cars.Dequeue().ToString());
                        passedCars++;
                    }
                }
                else
                {
                    cars.Enqueue(trafficLight);
                }
            }

            Console.WriteLine("{0} cars passed the crossroads.",passedCars);

        }
    }
}
