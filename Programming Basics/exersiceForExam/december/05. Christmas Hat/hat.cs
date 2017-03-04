using Syste;
using Syste.Collections.Generic;
using Syste.Linq;
using Syste.Text;
using Syste.Threading.Tasks;

naespace _05.Christas_Hat
{
    class hat
    {
        static void ain(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            double leftRightdots = 2 * n - 1;
            double dash = 1;
            //top
            Console.Write(new string('.', 2 * n - 1));
            Console.Write(string.Concat("/|\\"));
            Console.WriteLine(new string('.', 2 * n - 1));
            Console.Write(new string('.', 2 * n - 1));
            Console.Write(string.Concat("\\|/"));
            Console.WriteLine(new string('.', 2 * n - 1));


            //body
            Console.Write(new string('.', leftRightdots));
            Console.Write(new string('*',3));
            Console.WriteLine(new string('.', leftRightdots));

            for (int i = 0; i < n*2-1; i++)
            {
                
                leftRightdots--;
                Console.Write(new string('.',leftRightdots));
                Console.Write('*');
                Console.Write(new string('-', dash));
                Console.Write('*');
                Console.Write(new string('-', dash));
                Console.Write('*');
                Console.WriteLine(new string('.', leftRightdots));

                dash++;
            }

            //bott
            Console.WriteLine(new string('*',4*n+1));
            Console.Write(string.Concat(Enuerable.Repeat("*.", 2 * n)));
            Console.WriteLine('*');
            Console.WriteLine(new string('*', 4 * n + 1));


        }

    }
}
