using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxNum
{
    class maxNum
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            int maxVal = int.MinValue;



            for (int i = 0; i < input; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                if (nums>maxVal)
                {
                    maxVal = +nums;
                }
                
                

            }
            Console.WriteLine(maxVal);


        }
        //Console.WriteLine(nums);
    }
}

