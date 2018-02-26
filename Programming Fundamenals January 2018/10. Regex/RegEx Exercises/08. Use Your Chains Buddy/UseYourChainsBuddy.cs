using System;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Compete/Index/430#7
/// </summary>

namespace _08._Use_Your_Chains_Buddy
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            //Pattern for <p> tag.
            string pattern = @"<(p)>(.*?)<\/(\1)>";

            //We store result here as decripted values.
            StringBuilder decripted = new StringBuilder();


            foreach (Match m in Regex.Matches(text, pattern))
            {
                //We split every match at char array.
                var letters = m.Groups[2].Value.ToCharArray();

                for (int i = 0; i < letters.Length; i++)
                {
                    //If it's not small letter or digit.
                    if (!((letters[i] >= 'a' && letters[i] <= 'z') || (letters[i] >= '0' && letters[i] <= '9')))
                    {
                        //Replace with space.
                        letters[i] = (char)32;
                    }

                    //If it's 'a' make it 'm' ect.
                    if (letters[i]>='a'&&letters[i]<'n')
                    {
                        letters[i]+=(char)13;
                    }
                    //If it's 'n' make it 'a' ect.
                    else if(letters[i]>='n'&&letters[i]<='z')
                    {
                        letters[i]-=(char)13;
                    }
                    //Adding decripted symbol.
                    decripted.Append(letters[i]);

                }
            }
            //We split decripted symbols and joins them with single space
            //between them.
            var result=decripted.ToString().Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
