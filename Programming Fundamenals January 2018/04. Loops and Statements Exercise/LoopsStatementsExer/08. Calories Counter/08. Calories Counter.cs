using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfIngreeds = int.Parse(Console.ReadLine());
            int calories;
            int calSum = 0;

            for (int i = 0; i < numOfIngreeds; i++)
            {
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "cheese":
                        calories = 500;
                        calSum += calories;
                        break;
                    case "tomato sauce":
                        calories = 150;
                        calSum += calories;

                        break;
                    case "salami":
                        calories = 600;
                        calSum += calories;

                        break;
                    case "pepper":

                        calories = 50;
                        calSum += calories;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {calSum}");
        }
    }
}
