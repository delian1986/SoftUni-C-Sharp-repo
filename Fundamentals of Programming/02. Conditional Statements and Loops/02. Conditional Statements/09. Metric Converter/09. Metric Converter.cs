using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string val1 = Console.ReadLine();
            string val2 = Console.ReadLine();


            var m = 1 * num;
            var mm = num / 1000;
            var cm = num / 100;
            var mi = num / 0.000621371192;
            var inch = num / 39.3700787;
            var km = num / 0.001;
            var ft = num / 3.2808399;
            var yd = num / 1.0936133;


            var result = 0.00;

            if (val1 == "m")
            {
                switch (val2)
                {
                    case "m":
                        result = num;
                        break;

                    case "mm":
                        result = m*1000;
                        break;
                    case "cm":
                        result = m*100;
                        break;
                    case "mi":
                        result = m* 0.000621371192;
                        break;
                    case "in":
                        result = m * 39.3700787;
                        break;
                    case "km":
                        result = m* 0.001;
                        break;
                    case "ft":
                        result = m* 3.2808399;
                        break;
                    case "yd":
                        result = m* 1.0936133;
                        break;

                }
            }

            else if (val1 == "mm")
            {
                switch (val2)
                {
                    case "mm":
                        result = num;
                        break;

                    case "m":
                        result = mm;
                        break;

                    case "cm":
                        result = mm * 100;

                        break;

                    case "mi":
                        result = mm * 0.000621371192;
                        break;
                    case "in":
                        result = mm * 39.3700787;
                        break;
                    case "km":
                        result = mm * 0.001;
                        break;
                    case "ft":
                        result = mm * 3.2808399;
                        break;
                    case "yd":
                        result = mm * 1.0936133;
                        break;
                }
            }

            else if (val1 == "cm")
            {
                switch (val2)
                {
                    case "cm":
                        result = num;
                        break;
                    case "m":
                        result = cm;
                        break;
                    case "mm":
                        result = cm * 1000;
                        break;
                    case "mi":
                        result = cm * 0.000621371192;
                        break;
                    case "in":
                        result = cm * 39.3700787;
                        break;
                    case "km":
                        result = cm * 0.001;
                        break;
                    case "ft":
                        result = cm * 3.2808399;
                        break;
                    case "yd":
                        result = cm * 1.0936133;
                        break;
                }

            }
            else if (val1 == "mi")
            {
                switch (val2)
                {
                    case "mi":
                        result = num;
                        break;
                    case "m":
                        result = mi;
                        break;
                    case "mm":
                        result = mi * 1000;
                        break;
                    case "cm":
                        result = mi * 100;
                        break;
                    case "in":
                        result = mi * 39.3700787;
                        break;
                    case "km":
                        result = mi * 0.001;
                        break;
                    case "ft":
                        result = mi * 3.2808399;
                        break;
                    case "yd":
                        result = mi * 1.0936133;
                        break;
                }
            }
            else if (val1 == "in")
            {
                switch (val2)
                {
                    case "in":
                        result = num;
                        break;
                    case "m":
                        result = inch;
                        break;
                    case "mm":
                        result = inch * 1000;
                        break;
                    case "cm":
                        result = inch * 100;
                        break;
                    case "mi":
                        result = inch * 0.000621371192;
                        break;
                    case "km":
                        result = inch * 0.001;
                        break;
                    case "ft":
                        result = inch * 3.2808399;
                        break;
                    case "yd":
                        result = inch * 1.0936133;
                        break;
                }
            }
            else if (val1 == "km")
            {
                switch (val2)
                {
                    case "km":
                        result = num;
                        break;
                    case "m":
                        result = km;
                        break;
                    case "mm":
                        result = km * 1000;
                        break;
                    case "cm":
                        result = km * 100;
                        break;
                    case "mi":
                        result = km * 0.000621371192;
                        break;
                    case "in":
                        result = km * 39.3700787;
                        break;
                    case "ft":
                        result = km * 3.2808399;
                        break;
                    case "yd":
                        result = km * 1.0936133;
                        break;
                }
            }
            else if (val1 == "ft")
            {
                switch (val2)
                {
                    case "ft":
                        result = num;
                        break;
                    case "m":
                        result = ft;
                        break;
                    case "mm":
                        result = ft * 1000;
                        break;
                    case "cm":
                        result = ft * 100;
                        break;
                    case "mi":
                        result = ft * 0.000621371192;
                        break;
                    case "in":
                        result = ft * 39.3700787;
                        break;
                    case "km":
                        result = ft * 0.001;
                        break;
                    case "yd":
                        result = ft * 1.0936133;
                        break;
                }

            }
            else if (val1 == "yd")
            {
                switch (val2)
                {
                    case "yd":
                        result = num;
                        break;
                    case "m":
                        result = yd;
                        break;
                    case "mm":
                        result = yd * 1000;
                        break;
                    case "cm":
                        result = yd * 100;
                        break;
                    case "mi":
                        result = yd * 0.000621371192;
                        break;
                    case "in":
                        result = yd * 39.3700787;
                        break;
                    case "km":
                        result = yd * 0.001;
                        break;
                    case "ft":
                        result = yd * 3.2808399;
                        break;
                }
            }

            Console.WriteLine($"{result:f8}");
        }
    }
}