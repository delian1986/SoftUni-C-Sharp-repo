using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// This program read two files and sort alphabetically the elements in
/// another file.
/// </summary>

namespace MergeFiles
{
    class MergeFiles
    {
        static void Main()
        {
            string[]text1=File.ReadAllLines(@"FileOne.txt");
            string[]text2=File.ReadAllLines(@"FileTwo.txt");

            List<string>sortedList=new List<string>();
            sortedList.AddRange(text1);
            sortedList.AddRange(text2);
            sortedList.Sort();

            File.AppendAllLines(@"Output.txt",sortedList);
        }
    }
}
