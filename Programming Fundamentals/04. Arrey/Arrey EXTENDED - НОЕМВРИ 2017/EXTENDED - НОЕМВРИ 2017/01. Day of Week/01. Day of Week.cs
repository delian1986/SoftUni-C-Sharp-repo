using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] day = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var item = int.Parse(Console.ReadLine());


            if (item<1 || item>7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
            Console.WriteLine(day[item-1]);

            }
            // else
            //{
            //    for (int i = 0; i < day.Length; i++)
            //    {
            //        if (item - 1 == i)
            //        {
            //            Console.WriteLine(day[i]);

            //        }
            //    }
            //}



        }
    }
}
