using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/// <summary>
/// This program replace text with ***** by given pattern.
/// https://judge.softuni.bg/Contests/Practice/Index/320#2
/// </summary>

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(new char
                []{' ', ',' },StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            string result=string.Empty;

            for (int i = 0; i < banList.Length; i++)
            {
                string pattern=$@"{banList[i]}";
                string substitution =$@"{string.Concat(Enumerable.Repeat("*",banList[i].Length))}";
                Regex regex=new Regex(pattern);
                result = regex.Replace(text,substitution);
                text=result;
            }

            Console.WriteLine(result);
        }
    }
}
