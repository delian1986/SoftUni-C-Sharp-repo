using System;
using System.Linq;

/// <summary>
/// 0/100
/// </summary>

namespace _5._Rubik_Matrix
{
    class Program
    {
        private static int[,] matrix;
        private static int rows;
        private static int cols;

        static void Main()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            rows = dimensions[0];
            cols = dimensions[1];
            int number = 1;
            matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = number++;
                }
            }

            int numOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();
                int index = int.Parse(input[0]);
                string direction = input[1];
                int rotations = int.Parse(input[2]);

                switch (direction)
                {
                    case "left":
                        MoveRow(index, cols - rotations);
                        break;

                    case "right":
                        MoveRow(index, rotations);
                        break;

                    case "up":
                        MoveColumn(index, rows - rotations);
                        break;

                    case "down":
                        MoveColumn(index, rotations);
                        break;
                }
            }

            RearrageMatrix();

        }

        private static void RearrageMatrix()
        {

        }

        private static void MoveRow(int index, int rotations)
        {
            rotations %= cols;
            int[] tempArr = new int[cols];

            for (int col = 0; col < tempArr.Length; col++)
            {
                int replacement = col + rotations;

                replacement %= cols;
                tempArr[replacement] = matrix[index, col];
            }

            for (int col = 0; col < cols; col++)
            {
                matrix[index, col] = tempArr[col];
            }
        }

        private static void MoveColumn(int index, int rotations)
        {
            rotations %= rows;
            int[] tempArr = new int[rows];

            for (int row = 0; row < tempArr.Length; row++)
            {
                int replacement = row + rotations;

                replacement %= rows;
                tempArr[replacement] = matrix[index, row];
            }

            for (int row = 0; row < rows; row++)
            {
                matrix[row, index] = tempArr[row];
            }
        }
    }
}
