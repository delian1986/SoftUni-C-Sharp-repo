using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 
/// </summary>
namespace _05._Dict_Ref_Advanced
{
    class DictRefAdvanced
    {
        static void Main()
        {
            Dictionary<string,List<string>>dict=new Dictionary<string, List<string>>();

            string input=string.Empty;

            while ((input=Console.ReadLine())!="end")
            {

                string[]args=input.Split(new[]{ " -> ",","},StringSplitOptions.RemoveEmptyEntries);

                string name=args[0];

                List<string>digits=args.Skip(1).ToList();


            }
        }
    }
}
