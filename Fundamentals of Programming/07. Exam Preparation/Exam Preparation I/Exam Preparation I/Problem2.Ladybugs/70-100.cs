using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());
            int[] populatedField = new int[sizeOfTheField];

            int[] newBugs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(a => a >= 0 && a < sizeOfTheField)
                .ToArray();

            populatedField = PopulatingField(sizeOfTheField, populatedField, newBugs);

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();

                int ladyBug = int.Parse(tokens[0]);
                string direction = tokens[1];
                int count = int.Parse(tokens[2]);

                var insideArr = ladyBug >= 0 && ladyBug < sizeOfTheField;

                if (!insideArr)
                {
                    continue;
                }

                var IsThereALadyBug = populatedField[ladyBug] == 1;
                if (!IsThereALadyBug)
                {
                    continue;
                }


                if (direction == "left" && count > 0 || direction == "right" && count < 0)
                {
                    populatedField = MovingLeft(count, ladyBug, direction, populatedField);
                }
                else
                {
                    populatedField = MovingRight(count, ladyBug, direction, populatedField);

                }



            }
            Console.WriteLine(string.Join(" ", populatedField));



        }

        private static int[] MovingLeft(int count, int ladyBug, string direction, int[] populatedField)
        {

            count = Math.Abs(count);

            for (int i = populatedField[ladyBug]; i >= 0; i -= count)
            {
                populatedField[ladyBug] = 0;

                int desiredPosition = ladyBug - count;

                if (desiredPosition < 0)
                {
                    break;
                }


                else if (populatedField[desiredPosition] == 1)
                {

                    continue;
                }
                else
                {
                    populatedField[desiredPosition] = 1;
                    break;
                }
            }


            return populatedField;
        }

        private static int[] MovingRight(int count, int ladyBug, string direction, int[] populatedField)
        {

            count = Math.Abs(count);

            for (int i = populatedField[ladyBug]; i < populatedField.Length; i += count)
            {
                populatedField[ladyBug] = 0;

                int desiredPosition = ladyBug + count;

                if (desiredPosition > populatedField.Length - 1)
                {
                    break;
                }


                else if (populatedField[desiredPosition] == 1)
                {

                    continue;
                }
                else
                {
                    populatedField[desiredPosition] = 1;
                    break;
                }

            }
            return populatedField;
        }

        private static int[] PopulatingField(int sizeOfTheField, int[] populatingField, int[] newBugs)
        {
            for (int i = 0; i < newBugs.Length; i++)
            {
                for (int j = 0; j < populatingField.Length; j++)
                {

                    if (j == newBugs[i])
                    {
                        populatingField[j] = 1;
                        break;
                    }


                }
            }

            return populatingField;
        }
    }
}
