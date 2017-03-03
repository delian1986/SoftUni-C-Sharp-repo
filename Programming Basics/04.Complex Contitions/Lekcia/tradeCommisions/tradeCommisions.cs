using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tradeCommisions
{
    class tradeCommisions
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double commision = -1;

            if (city == "sofia")
            {
                if (0<=sales&&sales<=500)
                {
                    commision = sales * 0.05;

                }
                else if (500<sales&&sales<=1000)
                {
                    commision = sales * 0.07;
                }
                else if (1000<sales&&sales<=10000)
                {
                    commision = sales * 0.08;
                }
                else if (sales>10000)
                {
                    commision = sales * 0.12;
                }
            }
            if (city == "varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    commision = sales * 0.045;

                }
                else if (500 < sales && sales <= 1000)
                {
                    commision = sales * 0.075;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    commision = sales * 0.10;
                }
                else if (sales > 10000)
                {
                    commision = sales * 0.13;
                }
            }
            if (city == "plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    commision = sales * 0.055;

                }
                else if (500 < sales && sales <= 1000)
                {
                    commision = sales * 0.08;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    commision = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    commision = sales * 0.145;
                }
            }
            if (commision!=-1)
            {
                Console.WriteLine("{0:f2}", commision);

            }
            else
            {
                Console.WriteLine("error");

            }

        }
    }
}
