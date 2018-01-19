using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AnunymousThreat
{
    static void Main(string[] args)
    {
        List<string> array = Console.ReadLine().Split().ToList();

        string input = String.Empty;

        while ((input = Console.ReadLine()) != "3:1")
        {
            string[] tokens = input.Split();

            string command = tokens[0];
            int startIndex = int.Parse(tokens[1]);
            int endIndex = int.Parse(tokens[2]);

            if (command == "merge")
            {
                startIndex = int.Parse(tokens[1]);
                endIndex = int.Parse(tokens[2]);

                array = Merge(array, command, startIndex, endIndex);
            }
            else if (command == "divide")
            {
                int index = startIndex;
                int parts = endIndex;

                array = Divide(array, command, index, parts);
            }

        }

        Console.WriteLine(String.Join(" ", array));


    }

    private static List<string> Divide(List<string> array, string command, int index, int parts)
    {
        List<string> newList = new List<string>();

        var targetIndex = array[index];
        var splittedPartsNum = array[index].Count() / parts;
        var lastSplittedPart = array[index].Count() % parts;

        for (int i = 0; i <parts; i++)
        {
            if (i==parts-1)
            {
                newList.Add(targetIndex.Substring(i * splittedPartsNum));
            }
            else
            {
                newList.Add(targetIndex.Substring(i * splittedPartsNum, splittedPartsNum));
            }
        }
        array.RemoveAt(index);
        array.InsertRange(index, newList);


        return array;
    }

    private static List<string> Merge(List<string> array, string command, int startIndex, int endIndex)
    {
        List<string> newList = new List<string>();
        StringBuilder stringBuilder = new StringBuilder();

        if (startIndex < 0)
        {
            startIndex = 0;
        }
        else if (startIndex > array.Count - 1)
        {
            startIndex = startIndex - array.Count - 1;
        }
        if (endIndex > array.Count - 1)
        {
            endIndex = array.Count - 1;
        }
        else if (endIndex < 0)
        {
            endIndex = 0;
        }

        for (int i = 0; i < startIndex; i++)
        {
            newList.Add(array[i]);
        }

        for (int i = startIndex; i <= endIndex; i++)
        {

            stringBuilder.Append(array[i]);

        }
        newList.Add(stringBuilder.ToString());

        for (int i = endIndex + 1; i < array.Count; i++)
        {
            newList.Add(array[i]);
        }
        array = newList;

        return array;
    }
}
