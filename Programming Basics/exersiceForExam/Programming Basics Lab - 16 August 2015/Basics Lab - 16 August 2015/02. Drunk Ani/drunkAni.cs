using System;

namespace _02.Drunk_Ani
{
    class drunkAni
    {
        static void Main()
        {
            long numCab = int.Parse(Console.ReadLine());

            long totSteps = 0;
            long currPos = 0;
            long totLenghtCov = 0;

            while (true)
            {
                string nextComm = Console.ReadLine();
                if (nextComm== "Found a free one!")
                {
                    break;
                }
                totSteps = int.Parse(nextComm);

                long oldPoss = currPos;
                currPos = (currPos + totSteps) % numCab;
                long diff = currPos - oldPoss;

                if (diff>0)
                {
                    Console.WriteLine($"Go {Math.Abs(diff)} steps to the right, Ani.");
                }
                else if (diff<0)
                {
                    Console.WriteLine($"Go {Math.Abs(diff)} steps to the left, Ani.");
                }
                else
                {
                    Console.WriteLine("Stay there, Ani.");
                }
                totLenghtCov += Math.Abs((diff));

            }
            Console.WriteLine($"Moved a total of {totLenghtCov} steps.");
        }
    }
}
