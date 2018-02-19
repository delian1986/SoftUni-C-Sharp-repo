using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/// <summary>
/// This program matches substring by pattern and print number 
/// of occurencess.
/// https://judge.softuni.bg/Contests/Practice/Index/320#1
/// </summary>

namespace _02.Count_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            
            //With while loop and variable counter.
            int indexOfPattern=text.IndexOf(pattern);
            int counter=0;
            int position=0;
            while (true)
            {
                if (text[position+pattern.Length]>text.Length)
                {
                    break;
                }

                string patternPositions=text.Substring(position,pattern.Length);
               
                if (patternPositions==pattern)
                {
                    counter++;
                }
                position++;
            }
            Console.WriteLine(counter);

            //With regex expression.
           //pattern=$@"(?={pattern})";
           //var match=Regex.Matches(text,pattern).Count;
           //Console.WriteLine(match);

            ///string p = "pesho delyan";
            ///int indexOfD=p.IndexOf('d');
            ///
            ///string delyan=p.Substring(indexOfD,6);
            ///
            ///Console.WriteLine(delyan);
        }
    }
}
