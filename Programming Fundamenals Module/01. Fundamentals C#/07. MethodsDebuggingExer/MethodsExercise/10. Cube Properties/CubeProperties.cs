using System;

namespace _10._Cube_Properties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string prop=Console.ReadLine();

            double result=0;
            if (prop=="face")
            {
                result=FindFace(side);
            }
            else if (prop=="volume")
            {
                result=FindVolume(side);
            }
            else if (prop=="space")
            {
                result=FindSpaceDiagonal(side);
            }
            else if (prop=="area")
            {
                result=FindArea(side);
            }
            Console.WriteLine($"{result:f2}");
        }

        private static double FindArea(double side)
        {
            return 6*Math.Pow(side,2);
        }

        private static double FindSpaceDiagonal(double side)
        {
            return side*Math.Sqrt(3);
        }

        private static double FindVolume(double side)
        {
            return Math.Pow(side,3);
        }

        private static double FindFace(double side)
        {
            return side*Math.Sqrt(2);
        }


    }
}
