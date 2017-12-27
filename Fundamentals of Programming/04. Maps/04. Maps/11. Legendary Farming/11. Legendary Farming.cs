using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string,  int> legendary = new SortedDictionary<string,int>();


            legendary.Add("shards", 0);
            legendary.Add("fragments", 0);
            legendary.Add("motes", 0);

            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            string obtained = String.Empty;
            bool legend = false;

            while (!legend)
            {
                string[] drop = Console.ReadLine().ToLower().Split().ToArray();

                for (int i = 1; i < drop.Length; i += 2)
                {
                    int quantity = int.Parse(drop[i - 1]);
                    if (legendary.ContainsKey(drop[i]))
                    {
                        legendary[drop[i]] += quantity;
                        if (legendary["shards"]>=250)
                        {
                            legendary["shards"] -= 250;
                            obtained = "Shadowmourne obtained!";
                            legend = true;
                            break;
                        }
                        else if (legendary["fragments"] >= 250)
                        {
                            legendary["fragments"] -= 250;
                            obtained = "Valanyr obtained!";
                            legend = true;
                            break;

                        }
                        else if (legendary["motes"]>=250)
                        {
                            legendary["motes"] -= 250;
                            obtained = "Dragonwrath obtained!";
                            legend = true;
                            break;
                        }
                    }
                    //else if (legendary.ContainsKey(drop[i]))
                    //{
                    //    legendary["fragments"] += quantity;
                    //    if (l)
                    //    {
                    //        
                    //    }
                    //}
                    //else if ()
                    //{
                    //    legendary["motes"] += quantity;
                    //    if (legendary["motes"] >= 250)
                    //    {
                    //        
                    //
                    //    }
                    //}

                    else
                    {
                        if (!junk.ContainsKey(drop[i]))
                        {
                            junk.Add(drop[i], quantity);
                        }
                        else
                        {
                            junk[drop[i]] += quantity;

                        }
                    }
                }
            }
            Console.WriteLine(obtained);

            foreach (var item in legendary.OrderByDescending(n =>n.Value))
            {
                
                    Console.WriteLine("{0}: {1}",string.Join("",item.Key),string.Join("",item.Value));
                
            }

            foreach (var item in junk.OrderBy(n=>n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            
        }
    }
}