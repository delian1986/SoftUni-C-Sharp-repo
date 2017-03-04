using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1000daysonEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            string ftm = "dd-MM-yyyy";
            string value = Console.ReadLine();
            DateTime birthDay = DateTime.ParseExact(value, ftm, null);
            Console.WriteLine(birthDay.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
