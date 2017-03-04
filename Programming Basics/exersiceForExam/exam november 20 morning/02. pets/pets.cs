using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.pets
{
    class pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            var needDogFood = days * dogFood;
            var needCatFood = days * catFood;
            var needTurtleFood = (days * turtleFood)/1000;
            var result = needCatFood + needDogFood + needTurtleFood;
            if (result<= food)
            {
                var res = Math.Floor( food - result);
                Console.WriteLine("{0} kilos of food left." ,res);
            }
            else
            {
                var res = Math.Ceiling(result - food);
                Console.WriteLine("{0} more kilos of food are needed.", res);
            }
        
        }
    }
}
