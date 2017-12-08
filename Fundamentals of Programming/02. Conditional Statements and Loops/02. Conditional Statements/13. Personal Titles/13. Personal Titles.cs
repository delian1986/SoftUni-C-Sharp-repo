using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string result = String.Empty;

            if (gender == "m")
            {
                if (age >= 16)
                {
                    result = "Mr.";
                }
                else
                {
                    result = "Master";
                }
            }
            else if (gender=="f")
            {
                if (age>=16)
                {
                    result = "Ms.";
                }
                else
                {
                    result = "Miss";
                }
            }
            Console.WriteLine(result);
        }
    }
}
