using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/741#1
/// 100/100
/// </summary>

namespace _02._Entertrain
{
    class Entertrain
    {
        static void Main()
        {
            int locPow=int.Parse(Console.ReadLine());
            string input=string.Empty;
            
            //Here we store the wagons.
            List<int>train=new List<int>();

            while ((input=Console.ReadLine())!="All ofboard!")
            {
                int wagon=int.Parse(input);
                train.Add(wagon);
                
                if (train.Sum()>locPow)
                {
                    //We need the value to be integer.
                    int avg=(int)train.Average();
                    
                    //With this we calculate closest to averange.
                    //This method don't have to sort the list.
                    //TY StackOverflow https://stackoverflow.com/questions/5953552/how-to-get-the-closest-number-from-a-listint-with-linq
                    int closest=train.Aggregate((x,y)=>Math.Abs(x-avg)<Math.Abs(y-avg) ? x:y);
                    
                    //We remove the closest element.
                    train.Remove(closest);
                }
            }

            train.Reverse();

            Console.WriteLine(string.Join(" ",train)+" "+locPow);
        }
    }
}
