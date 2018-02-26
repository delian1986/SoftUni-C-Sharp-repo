using System;
using System.IO;

namespace _02._AdvertisementMessage
{
    /// <summary>
    /// Generate random ad from the template below.
    /// </summary>
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            string[] phases = new string[]
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

            string[] events = new string[]
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

            string[] authors = new string[]
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        };

            string[] cities = new string[]
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

            Random random=new Random();

            int numOfMessages=int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfMessages; i++)
            {
                //Random Phase.
                string randomPhase= phases[random.Next(0,phases.Length)];

                //Random Event.
                string randomEvent= events[random.Next(0,events.Length)];

                //Random Author
                string randomAuthor= authors[random.Next(0,authors.Length)];

                //Random City
                string randomCity= cities[random.Next(0,cities.Length)];

                File.AppendAllText("Output.txt",$"{randomPhase} {randomEvent} {randomEvent} – {randomCity}."+Environment.NewLine);
            }
        }

        
    }
}