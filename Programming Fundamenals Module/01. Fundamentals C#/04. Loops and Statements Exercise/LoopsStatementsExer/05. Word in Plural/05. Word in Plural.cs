using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string newWord;

            if (word.EndsWith("y"))
            {
                newWord = word.Remove(word.Length-1);
                newWord += "ies";
            }
            else if (word.EndsWith("o")|| word.EndsWith("ch")|| word.EndsWith("s")|| word.EndsWith("sh")|| word.EndsWith("x")|| word.EndsWith("z"))
            {
                newWord = word + "es";
            }
            else
            {
                newWord = word + "s";
            }

            Console.WriteLine(newWord);
        }

    }
}
