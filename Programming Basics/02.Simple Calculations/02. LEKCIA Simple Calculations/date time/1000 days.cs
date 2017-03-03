using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateofBirth = DateTime.Parse(Console.ReadLine());
            dateofBirth = dateofBirth.AddDays(999);
            Console.WriteLine("1000 days after birth: {0}", dateofBirth.ToString("dd-MM-yyyy"));
        }
    }
}
