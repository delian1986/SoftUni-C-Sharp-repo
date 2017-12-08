using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.Check_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool result = true;

            if (num < 2)
            {
                result = false;
            }
            

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                
                }
                else
                {
                    result = true;

                }
            }
            if (result)
            {
                   
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
