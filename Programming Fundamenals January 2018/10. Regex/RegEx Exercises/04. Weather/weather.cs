using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// https://judge.softuni.bg/Contests/Compete/Index/430#3
/// </summary>

namespace _04._Weather
{
    class Weather
    {
        static void Main()
        {
            string forecast = string.Empty;

            Dictionary<string, Dictionary<double, string>> weather = new Dictionary<string, Dictionary<double, string>>();

            //This pattern matches valid forecast from the text.
            string pattern = @"(?<city>[A-Z]{2})(?<temp>\d+.\d{1,2})(?<cast>[A-Za-z]+)+\|";

            while ((forecast = Console.ReadLine()) != "end")
            {
                foreach (Match item in Regex.Matches(forecast, pattern))
                {
                    //Assign groups as variables.
                    string city = item.Groups["city"].Value;
                    double temp = double.Parse(item.Groups["temp"].Value);
                    string cast = item.Groups["cast"].Value;

                    //Populating dictionary.
                    if (!weather.ContainsKey(city))
                    {
                        var innerDict = new Dictionary<double, string>();
                        innerDict.Add(temp, cast);
                        weather.Add(city, innerDict);
                    }
                    else
                    {
                        //If the weather is changed we keep the last values.
                        var innerDict = new Dictionary<double, string>();
                        innerDict.Add(temp, cast);
                        weather[city] = (innerDict);
                    }
                }
            }

            //Printing the result.
            foreach (var city in weather.OrderBy(x => x.Value.Keys.First()))
            {
                Console.WriteLine($"{city.Key} => {string.Join("", city.Value.Keys):f2} => {string.Join("", city.Value.Values)}");
            }
        }
    }
}
