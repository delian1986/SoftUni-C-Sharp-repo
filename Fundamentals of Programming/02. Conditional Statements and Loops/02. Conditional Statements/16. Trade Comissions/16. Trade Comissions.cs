using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            var comm = 0.0;
            if (sales<0)
            {
                Console.WriteLine("error");
                return;
            }

            if (city=="sofia")
            {
                if (sales>=0&&sales<=500)
                {
                comm = sales * 0.05;

                }
                else if (sales>500&&sales<=1000)
                {
                    comm = sales * 0.07;

                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comm = sales * 0.08;

                }
                else if (sales > 10000 )
                {
                    comm = sales * 0.12;

                }
            }
            else if (city=="varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comm = sales * 0.045;

                }
                else if (sales > 500 && sales <= 1000)
                {
                    comm = sales * 0.075;

                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comm = sales * 0.1;

                }
                else if (sales > 10000)
                {
                    comm = sales * 0.13;

                }
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comm = sales * 0.055;

                }
                else if (sales > 500 && sales <= 1000)
                {
                    comm = sales * 0.08;

                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comm = sales * 0.12;

                }
                else if (sales > 10000)
                {
                    comm = sales * 0.145;

                }

            }
            else
            {
                Console.WriteLine("error");
                return;
            }
            Console.WriteLine($"{comm:f2}");
        }
    }
}
