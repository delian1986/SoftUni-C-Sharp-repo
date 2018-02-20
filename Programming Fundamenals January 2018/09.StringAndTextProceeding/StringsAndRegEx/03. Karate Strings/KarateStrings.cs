using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Karate_Strings
{
    class KarateStrings
    {
        static void Main()
        {
            var text = Console.ReadLine().ToCharArray().ToList();
            int chavka = 0;
            try
            {
                int power = 0;
                chavka = text.IndexOf('>');
                for (int i = chavka + 1; i < text.Count; i++)
                {
                    if (text[i - 1] == '>' && text[i] > '0' && text[i] <= '9')
                    {
                        power += text[i] - 48;
                    }

                    if (text[i] != '>' && power > 0)
                    {
                        text.RemoveAt(i);
                        i--;
                        power--;
                    }
                }

            }
            catch
            {

            }

            Console.WriteLine(string.Join("", text));

        }
    }
}
