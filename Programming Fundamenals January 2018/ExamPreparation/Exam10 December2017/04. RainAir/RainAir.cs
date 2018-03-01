using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 100/100
/// https://judge.softuni.bg/Contests/Practice/Index/881#1
/// </summary>

namespace _04._RainAir
{
    class RainAir
    {
        static void Main()
        {
            //Here we store all flights and all customers.
            Dictionary<string,List<int>>rainAir=new Dictionary<string, List<int>>();
            string input=string.Empty;

            while ((input=Console.ReadLine())!="I believe I can fly!")
            {
                //If inputline contains '=' then we need to merge flights between customers. 
                if (input.Contains("="))
                {
                    string[]args=input.Split(new[]{' ','=' },StringSplitOptions.RemoveEmptyEntries);
                    string name=args[0];
                    string name1=args[1];

                    //We took List of second customer.
                    var cust2=rainAir[name1];

                    //We make new List to first customer.
                    rainAir[name]=new List<int>();
                    //Beware of reference.
                    rainAir[name]=cust2.ToList();

                }
                else
                {
                    //populating the main dicitonary.
                    string[]args=input.Split();
                    string name = args[0];
                    List<int>flights=new List<int>();

                    //Populating flight list.
                    for (int i = 1; i < args.Length; i++)
                    {
                        flights.Add(int.Parse(args[i]));
                    }

                    if (!rainAir.ContainsKey(name))
                    {
                        rainAir.Add(name,new List<int>());
                    }
                    rainAir[name].AddRange(flights);
                }
            }

            //The ordering.
            var ordered=rainAir.
                OrderByDescending(x=>x.Value.Count)
                .ThenBy(x=>x.Key);
                

            foreach (var user in ordered)
            {
                Console.WriteLine($"#{user.Key} ::: {string.Join(", ",user.Value.OrderBy(x=>x))}");
               
            }
        }
    }
}
