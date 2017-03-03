using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age
{
    class age
    {
        static void Main(string[] args)
        {
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            int age = today.Year - birthDay.Year;
            if (birthDay.Day > today.Day)
            {

                age--;
            }
            Console.WriteLine(age);
            age += 10;
            Console.WriteLine(age);


        }
    }
}
