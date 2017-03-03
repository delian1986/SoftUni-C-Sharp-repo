using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n%2==1)
                    {
                        Console.WriteLine("The number is not even.");

                    }
                    else if(n%2==0)
                    {
                        break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("Even number entered: "+n);
        }
    }
}


