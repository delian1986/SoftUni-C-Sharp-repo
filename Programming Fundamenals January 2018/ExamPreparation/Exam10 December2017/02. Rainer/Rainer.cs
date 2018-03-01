using System;
using System.Linq;

/// <summary>
/// This is a litte game with arrays. On every turn we decreace every element
/// of the array by 1. If the element goes on 0 we give the element inital 
/// the value. We switch our position by the number from the console.
/// https://judge.softuni.bg/Contests/Practice/Index/869#1
/// </summary>

namespace _02._Rainer
{
    class Rainer
    {
        static void Main()
        {

            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //Here program generate game field.
            int[] gameField = GeneratingGameFiled(sequence);
            //This is the start position.
            int donaldPosition = sequence.Last();
            int steppes = 0;
            bool isHeGetsWet = false;


            while (!isHeGetsWet)
            {
                //We decrece every element by 1.
                for (int i = 0; i < gameField.Length; i++)
                {
                    gameField[i] -= 1;
                }

                //We check if we are on 0 element.
                for (int i = 0; i < gameField.Length; i++)
                {
                    //If we are game over.
                    if (donaldPosition==i&&gameField[i]==0)
                    {
                        isHeGetsWet=true;
                        break;
                    }
                }
                if (isHeGetsWet)
                {
                    break;
                }

                //If there is 0 element and we are not in this index the 
                //element goes back to initial position. 
                for (int i = 0; i < gameField.Length; i++)
                {
                    if (gameField[i]==0)
                    {
                        gameField[i]=sequence[i];
                    }
                }

                //Step +1.
                steppes++;
                int nextStep = int.Parse(Console.ReadLine());
                donaldPosition=nextStep;
            }

            Console.WriteLine(string.Join(" ", gameField));
            Console.WriteLine(steppes);
        }

       
        private static int[] GeneratingGameFiled(int[] sequence)
        {
            int[] field = new int[sequence.Length - 1];
       
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = sequence[i];
            }
            return field;
        }
    }
}
