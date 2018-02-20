using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Pizza_Ingredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine().Split().ToList();
            int lenghtOfProduct=int.Parse(Console.ReadLine());

            List<string> ingredients = new List<string>();

            foreach (string ingredient in sequence)
            {
                if (ingredient.Length==lenghtOfProduct)
                {
                    ingredients.Add(ingredient);
                    Console.WriteLine($"Adding {ingredient}.");
                }
                if (ingredients.Count>=10)
                {
                    break;
                }
            }

            Console.WriteLine($"Made pizza with total of {ingredients.Count} ingredients.");
            Console.WriteLine("The ingredients are: {0}.",string.Join(", ",ingredients));
        }
    }
}
