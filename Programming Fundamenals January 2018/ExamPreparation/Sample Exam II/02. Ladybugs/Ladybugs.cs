using System;
using System.Linq;

/// <summary>
/// https://judge.softuni.bg/Contests/Practice/Index/454#1
/// 100/100
/// </summary>

namespace _02._Ladybugs
{
    class Ladybugs
    {
        static void Main()
        {

            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize].ToArray();

            //Take only valid indexes.
            var bugs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(i => i >= 0 && i < fieldSize)
                .ToList();

            //Populating field.
            foreach (var item in bugs)
            {
                field[item] = 1;
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                //0 left 5;
                string[] args = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int startIndex = int.Parse(args[0]);
                string direction = args[1];
                int flyLength = int.Parse(args[2]);

                if (direction == "left")
                {
                    flyLength *= -1;
                }

                //Outside of the field.
                if (startIndex >= field.Length || startIndex < 0)
                {
                    continue;
                }

                //No bug here. Check this after position validation!
                if (field[startIndex] == 0)
                {
                    continue;
                }

                //Ladybug fly away.
                field[startIndex] = 0;

                while (true)
                {
                    //New position.
                    int destination = startIndex + flyLength;

                    if (destination >= field.Length || destination < 0)
                    {
                        //Outside of the field.
                        break;
                    }
                    else if (destination < field.Length && field[destination] == 0)
                    {
                        //The field is empty and bug lands.
                        field[destination] = 1;
                        break;
                    }
                    else if (destination < field.Length && field[destination] == 1)
                    {
                        //The field is not empty and the bug continue.
                        startIndex = destination;
                    }

                }

            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
