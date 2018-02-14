using System;
using System.Collections.Generic;
using System.Linq;


namespace _10._Srbsko_Unleashed
{
    class SrbskoUnleashed
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> srbsko = new Dictionary<string, Dictionary<string, long>>();

            string input = string.Empty;

            
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(new string[] {" @"}, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in tokens)
                {
                    if (item.Contains("@"))
                    {
                        break;
                    }
                }
            }
        }
    }
}
