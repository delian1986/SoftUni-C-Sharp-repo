using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// https://judge.softuni.bg/Contests/Compete/Index/430#2
/// </summary>

namespace _03._Camera_View
{
    class CameraView
    {

        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToSkip = input[0] + 2;
            int elementsToTake = input[1];

            //Pattern to establish if there is valid camera.
            string pattern = @"\|\<";
            string text = Console.ReadLine();
           
            List<string> album = new List<string>();

            foreach (Match word in Regex.Matches(text, pattern))
            {
                //Establish camera positin.
                int cameraPositions = word.Index;

                //Enshure that the indexes are in the bounds of the array.
                if (cameraPositions+elementsToSkip+elementsToTake>text.Length)
                {
                    elementsToTake=text.Length-(cameraPositions+elementsToSkip);
                }
                //Taking the text as substring.
                string picture = text.Substring(cameraPositions + elementsToSkip, elementsToTake);

                //If there is another camera.
                if (picture.Contains("|"))
                {
                    int positionsOfPipe = picture.IndexOf("|");
                    picture=picture.Remove(positionsOfPipe, picture.Length - positionsOfPipe);
                }
                album.Add(picture);
            }

            Console.WriteLine(string.Join(", ",album));
        }
    }
}
