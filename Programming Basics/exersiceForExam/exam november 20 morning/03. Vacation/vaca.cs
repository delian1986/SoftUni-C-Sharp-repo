using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class vaca
    {
        static void Main(string[] args)
        {
            int add = int.Parse(Console.ReadLine());
            int child = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            var port = Console.ReadLine();
            var costAdd = 0.00;
            var costChild = 0.00;
            var result = 0.00;
            if (port == "airplane")
            {
                costAdd = 70.00;
                costChild = 50.00;
         
            }
            if (port == "train")
            {
                costAdd = 24.99;
                costChild = 14.99;
                if (add + child >= 50)
                {
                    costAdd = costAdd * 0.50;
                    costChild = costChild * 0.50;
                }
            
            }
            if (port == "boat")
            {
                costAdd = 42.99;
                costChild = 39.99;


            }
            if (port == "bus")
            {
                costAdd = 32.50;
                costChild = 28.50;


            }

            var costTrans = 2 * ((add * costAdd) + (child * costChild));
            var hotel = nights * 82.99;
            var comm = (costTrans + hotel) * 0.10;
            result = costTrans + hotel + comm;

            Console.WriteLine("{0:f2}", result);

        }
    }
}
