using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._4_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bot
        {
            get
            {
                return Top - Height;
            }
        }

        public int Area => Width * Height;
    }
}
