using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AnunymousThreat
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] line = Console.ReadLine().Split();

        List<string> list = new List<string>();

        while (line[0] != "3:1")
        {
            string command = line[0];
            int startIndex = int.Parse(line[1]);
            int endIndex = int.Parse(line[2]);

            if (command == "merge")
            {

                if (endIndex >= list.Count)
                {
                    endIndex = list.Count - 1;
                }
                if (startIndex<0)
                {
                    startIndex = 0;
                }
                if (endIndex<0)
                {
                    endIndex = 0;
                }

                // first part
                for (int i = 0; i < startIndex; i++)
                {
                    list.Add(input[i]);
                }

                //mid part
                StringBuilder merge = new StringBuilder();
                for (int i = startIndex; i <=endIndex; i++)
                {
                    merge.Append(input[i]);
                }
                string merged = merge.ToString();
                list.Add(merged);
                merge.Clear();

                //lastPart

                for (int i = endIndex; i < input.Length; i++)
                {
                    list.Add(input[i]);
                }
            }
            line = Console.ReadLine().Split();

        }

        Console.WriteLine(string.Join("",list));
    }
}
