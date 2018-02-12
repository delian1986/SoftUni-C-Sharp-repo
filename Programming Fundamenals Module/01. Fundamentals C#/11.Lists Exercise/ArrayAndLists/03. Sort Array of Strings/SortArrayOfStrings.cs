using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>seqence=Console.ReadLine().Split().ToList();
            //seqence.Sort();

            for (int i = 0; i < seqence.Count; i++)
            {
                for (int j = 0; j < seqence.Count-1; j++)
                {
                    int res=seqence[j].CompareTo(seqence[j+1]);

                    if (res==1)
                    {
                        var temp=seqence[j];
                        seqence[j]=seqence[j+1];
                        seqence[j+1]=temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",seqence) );
        }
    }
}
