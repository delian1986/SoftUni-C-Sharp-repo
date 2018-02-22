using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Camera_View
{
    class CameraView
    {

        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToSkip = input[0] + 2;
            int elementsToTake = input[1];

            string pattern = @"\|\<";
            string text = Console.ReadLine();

           
            List<string> album = new List<string>();

            foreach (Match word in Regex.Matches(text, pattern))
            {
                int cameraPositions = word.Index;
                if (cameraPositions+elementsToSkip+elementsToTake>text.Length)
                {
                    elementsToTake=text.Length-(cameraPositions+elementsToSkip);
                }
                string camera = text.Substring(cameraPositions + elementsToSkip, elementsToTake);

                if (camera.Contains("|"))
                {
                    int positionsOfPipe = camera.IndexOf("|");
                    camera=camera.Remove(positionsOfPipe, camera.Length - positionsOfPipe);
                }
                album.Add(camera);
            }

            Console.WriteLine(string.Join(", ",album));
        }
    }
}
