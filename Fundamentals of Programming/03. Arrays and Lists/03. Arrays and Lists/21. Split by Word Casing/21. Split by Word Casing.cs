using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split(new char[] { ',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i].All(c => char.IsUpper(c)))
                {
                    upperCase.Add(myList[i]);
                }
                else if (myList[i].All(c => char.IsLower(c)))
                {
                    lowerCase.Add(myList[i]);
                }
                else
                {
                    mixedCase.Add(myList[i]);
                }
            }
            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lowerCase));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedCase));
            Console.Write("Upper-case: ");
                Console.WriteLine(string.Join(", ", upperCase));


        }
    }
}
