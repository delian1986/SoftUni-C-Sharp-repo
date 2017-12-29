using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.Classes_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var firstCat = new Cat();
            //firstCat.Name = "Pesho";
            //firstCat.Age = 2;
            //firstCat.Color = "black";
            //firstCat.IsSleeping = true;
            //
            //var secondCat = new Cat();
            //secondCat.Name = "Jelqzko";
            //secondCat.Age = 1;
            //secondCat.Color = "Grey";
            //secondCat.IsSleeping = false;

            var cat = new Cat
            {
                Name = "Gosho",
                Color = "White",
                Age = 1,
                IsSleeping = false
            };

            var cat2 = new Cat
            {
                Name = "Stiv",
                Age = 2
            };

            cat.GoToSleep();
            Console.WriteLine(cat.SayHello());

            var cat2Intro = cat2.SayHello();
            Console.WriteLine(cat2Intro);
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public bool IsSleeping { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public string SayHello()
        {
            if (IsSleeping == true)
            {
                return "Sorry I sleep";
            }
            else
            {

                return $"My name is {Name}, I am {Age} years old";
            }
        }

        public void GoToSleep()
        {
            IsSleeping = true;
        }
    }
}
