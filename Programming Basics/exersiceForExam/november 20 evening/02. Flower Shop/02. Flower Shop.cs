using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int mag = int.Parse(Console.ReadLine());
            int zum = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int cac = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal sum = (mag * 3.25m + zum * 4m + rose * 3.50m + cac * 8m);
            decimal tax = sum*0.05m;
            decimal totSum = sum - tax;
            if (totSum>=price)
            {
                decimal mon = Math.Floor(totSum - price);
                Console.WriteLine("She is left with {0} leva.", mon);
            }
            else if (price>totSum)
            {
                decimal mon = Math.Ceiling(price - totSum);
                Console.WriteLine("She will have to borrow {0} leva.", mon);
            }
        }
    }
}
