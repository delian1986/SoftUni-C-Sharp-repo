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
            string commant = line[0];
            int starIndex = int.Parse(line[1]);
            int endIndex = int.Parse(line[2]);

            if (commant == "merge")
            {
                var merge = String.Empty;

                if (endIndex >= input.Length)
                {
                    endIndex = input.Length - 1;
                }
                for (int i = starIndex; i <= endIndex; i++)
                {
                    merge += String.Concat(input[i]);
                }
                list.Add(merge);
                list.Add(endIndex, input.Length);
            }
        }


    }
}
