using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> enter = Console.ReadLine().Split(new char[] { ',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },  StringSplitOptions.RemoveEmptyEntries).ToList();



            List<string> lowerCase = new List<string>();
            List<string> UpperCase = new List<string>();
            List<string> mixedCase = new List<string>();




            for (int i = 0; i < enter.Count; i++)
            {

                
                if (enter[i].All(c=>char.IsUpper(c)))
                {
                    UpperCase.Add(enter[i]);
                }
                else if (enter[i].All(c=>char.IsLower(c)))
                {
                    lowerCase.Add(enter[i]);
                }
                else
                {
                    mixedCase.Add(enter[i]);
                }
            }

          

            Console.Write("Lower-case: ");
            Console.WriteLine(String.Join(", ",lowerCase));
            Console.Write("Mixed-case: ");
            Console.WriteLine(String.Join(", ", mixedCase));
            Console.Write("Upper-case: ");
            Console.WriteLine(String.Join(", ", UpperCase));


        }
    }
}
