using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Task 04:
    // Write a program that count the result of a game. On the first line we get the number of the moves that comes next. On the next N lines we get one new number which we should do the calculations with it. If that number is 0 or bigger than 50 then this number is invalid. In the beggining the result is equal to 0. Then: 
    //  0->9=20% of the number
    //  10->19=30% of the number
    //  20->29=40% of the number
    //  30->39=50 points
    //  40->50=100 points
    //  If the number is invalid then we should divide the result by 2
    // Output:
    // Print the result. Print the percent of the numbers in each of the intervals. 
    // For the full solution condition view in folder.
    //GLHF

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var movesCount = int.Parse(Console.ReadLine());
            var result = 0.0;
            var zeroToNine = 0.0;
            var tenToNineteen = 0.0;
            var twenTotwntNine = 0.0;
            var thirdTothirdNine = 0.0;
            var forthToFift = 0.0;
            var invalid = 0.0;

            for (int i = 0; i < movesCount; i++)
            {
                var moves = int.Parse(Console.ReadLine());

                if (moves>=0&&moves<=9)
                {
                    result += moves * 0.20;
                    zeroToNine++;
                }
                else if (moves>=10&&moves<=19)
                {
                    result += moves * 0.30;
                    tenToNineteen++;
                }
                else if (moves>=20&&moves<=29)
                {
                    result += moves * 0.40;
                    twenTotwntNine++;
                }
                else if (moves>=30&&moves<=39)
                {
                    result += 50;
                    thirdTothirdNine++;
                }
                else if (moves>=40&&moves<=50)
                {
                    result += 100;
                    forthToFift++;
                }
                else if (moves<0||moves>50)
                {
                    result /= 2;
                    invalid++;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {(zeroToNine/ movesCount*100):f2}%");
            Console.WriteLine($"From 10 to 19: {(tenToNineteen / movesCount*100):f2}%");
            Console.WriteLine($"From 20 to 29: {(twenTotwntNine / movesCount*100):f2}%");
            Console.WriteLine($"From 30 to 39: {(thirdTothirdNine / movesCount*100):f2}%");
            Console.WriteLine($"From 40 to 50: {(forthToFift / movesCount * 100):f2}%");
            Console.WriteLine($"Invalid numbers: {(invalid/movesCount*100):f2}%");
        }
    }
}
