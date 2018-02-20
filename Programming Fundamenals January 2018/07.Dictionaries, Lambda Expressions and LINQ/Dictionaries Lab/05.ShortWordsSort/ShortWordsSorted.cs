using System;
using System.Linq;

namespace _05.ShortWordsSort
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            string[]text=Console.ReadLine().ToLower().Split(new[]{'.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?',' '},StringSplitOptions.RemoveEmptyEntries).ToArray();

            var sorted=text.Distinct().OrderBy(x=>x).Where(x=>x.Length<5);

            Console.WriteLine(string.Join(", ",sorted));
        }
    }
}
