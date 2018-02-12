using System;
using System.Linq;
using System.Collections.Generic;


namespace _06._Fold_and_Sum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int kaElements=sequence.Length/4;

            var firstPart=sequence.Take(kaElements).Reverse().ToList();
            var lastPart=sequence.Skip(3*kaElements).Take(kaElements).Reverse().ToList();
            var middlePart=sequence.Skip(kaElements).Take(2*kaElements).ToList();

            List<int>firstRow=new List<int>();

            firstRow.AddRange(firstPart);
            firstRow.AddRange(lastPart);

            var sum=firstRow.Select((x,index)=>x+middlePart[index]);

            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
