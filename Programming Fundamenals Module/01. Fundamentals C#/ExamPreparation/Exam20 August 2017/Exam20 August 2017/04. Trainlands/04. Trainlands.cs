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
            Dictionary<string, List<Train>> train = new Dictionary<string, List<Train>>();


            string input;

            while ((input = Console.ReadLine()) != "It's Training Men!")
            {
                if (input.Contains("->"))
                {
                    string[] tokens = input.Split(new[] { '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                    if (tokens.Length==2)
                    {
                        if (!train.ContainsKey(tokens[1]))
                        {
                            train.Add(tokens[1], new List<Train>());
                            var sa = train.FirstOrDefault(x => x.Key == tokens[0]);
                    }
                    else
                    {

                        train = populatingTrains(input, train);
                    }

                }
                else if (input.Contains("="))
                {

                }
            }

        }

        private static Dictionary<string, List<Train>> populatingTrains(string input, Dictionary<string, List<Train>> train)
        {


            List<Train> trainList = new List<Train>();
            string trainName = tokens[0];

            Train newTrain = new Train
            {
                WagonName = tokens[1],
                WagonPower = int.Parse(tokens[2])
            };

            trainList.Add(newTrain);


            if (!train.ContainsKey(trainName))
            {
                train.Add(trainName, new List<Train>());
            }
            train[trainName].AddRange(trainList);


            return train;
        }
    }
}
