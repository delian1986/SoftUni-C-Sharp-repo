using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainCast
{
    class Rainer
    {
        static void Main(string[] args)
        {
            int[] playGround = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] donaldGround = new int[playGround.Length - 1];
            Array.Copy(playGround, donaldGround, playGround.Length - 1);

            int donaldSteps = playGround.Last();

            bool IsHeGetsWet = false;
            var count = 0;
            int step = 0;

            while (!IsHeGetsWet == true)
            {
                if (count > 0)
                {
                    donaldSteps = step;
                }

                for (int i = 0; i < donaldGround.Length; i++)
                {
                    donaldGround[i] -= 1;

                }

                for (int i = 0; i < donaldGround.Length; i++)
                {

                    if (donaldGround[i] == 0 && donaldSteps == i)
                    {
                        IsHeGetsWet = true;
                        break;
                    }
                }
                if (IsHeGetsWet)
                {
                    break;
                }

                for (int i = 0; i < donaldGround.Length; i++)
                {

                    if (donaldGround[i] <= 0)
                    {
                        donaldGround[i] = playGround[i];
                    }
                }
                count++;
                if (IsHeGetsWet == false)
                {
                    step = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine(string.Join(" ", donaldGround));
            Console.WriteLine(count);
        }
    }
}
