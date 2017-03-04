using System;
 
namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int bonusScore = int.Parse(Console.ReadLine());
            switch (bonusScore)
            {
                case 1:
                case 2:
                case 3: Console.WriteLine(bonusScore * 10); break;
                case 4:
                case 5:
                case 6: Console.WriteLine(bonusScore * 100); break;
                case 7:
                case 8:
                case 9: Console.WriteLine(bonusScore * 1000); break;
                default:
                    if ((bonusScore == 0) || (bonusScore > 9))
                    {
                        Console.WriteLine("invalid score"); ;
                    }
                    break;
            }
        }
    }
}
