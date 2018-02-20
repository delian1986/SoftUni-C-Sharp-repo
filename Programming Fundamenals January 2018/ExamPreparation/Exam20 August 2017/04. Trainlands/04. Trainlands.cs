using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    public class Train
    {
        public string WagonName { get; set; }
        public int WagonPower { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,int>> train = new Dictionary<string, Dictionary<string, int>>();


            string input;

            while ((input = Console.ReadLine()) != "It's Training Men!")
            {
                if (!input.Contains("->")) continue;
                string[] tokens = input.Split(new[] { '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 2)
                {
                    var firstTrain = tokens[0];
                    var otherTrain = tokens[1];
                    if (!train.ContainsKey(tokens[0]))
                    {

                        train.Add(firstTrain, new Dictionary<string, int>());
                        var otherTrainWagons = train[otherTrain];
                            
                        train[firstTrain].Add(otherTrainWagons);
                        train.Remove(otherTrain);
                    }
                    else
                    {
                        var otherTrainWagons = train[otherTrain];

                    }

                }
                else
                {
                    train = PopulatingTrains(input, train, tokens);

                }

            }


        }

        private static Dictionary<string, Dictionary<string, int>> PopulatingTrains(string input, Dictionary<string, Dictionary<string, int>> train, string[] tokens)
        {
            string trainName = tokens[0];
            string wagonName = tokens[1];
            int wagonPower = int.Parse(tokens[2]);

            if (!train.ContainsKey(trainName))
            {
                train.Add(trainName, new Dictionary<string, int>());
            }
            train[trainName].Add(wagonName,wagonPower);


            return train;
        }
    }
}
