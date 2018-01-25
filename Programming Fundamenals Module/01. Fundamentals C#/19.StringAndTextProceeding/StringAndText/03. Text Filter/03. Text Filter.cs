using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(' ', ',');
            string text = Console.ReadLine();

            int index = text.IndexOf(banList[0]);

            while (index!=-1)
            {

            }

        }
    }
}
