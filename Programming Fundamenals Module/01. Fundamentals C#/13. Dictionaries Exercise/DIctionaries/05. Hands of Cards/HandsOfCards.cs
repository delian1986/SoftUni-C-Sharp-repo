using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// This is a program witch calculate the points in card game. Note that every player should have only unique cards.
/// https://judge.softuni.bg/Contests/Compete/Index/209#4
/// </summary>

namespace _05._Hands_of_Cards
{
    class HandsOfCards
    {
        static void Main()
        {
            string inputLine = String.Empty;
            //The main structure where the program stores the players and their cards. It uses HashSet because the cards should be unique for each player.
            Dictionary<string, HashSet<string>> playerHands = new Dictionary<string, HashSet<string>>();


            while ((inputLine = Console.ReadLine()) != "JOKER")
            {
                string[] args = inputLine.Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                //Player Name
                string player = args[0];

                //Player cards.
                string[]hands=args[1].Split(new char[]{',',' ' },StringSplitOptions.RemoveEmptyEntries);

                if (!playerHands.ContainsKey(player))
                {
                    playerHands.Add(player, new HashSet<string>());
                }

                for (int i = 0; i < hands.Length; i++)
                {
                    playerHands[player].Add(hands[i]);
                }
            }

            //Here the program calculate the score from the cards
            foreach (var player in playerHands)
            {
                //Total sum.
                int sum = 0;

                //Card power.
                int card = 0;
                foreach (var hand in player.Value)
                {
                    //Here the program split hand to elements. ex. 2D -> 2 and D.
                    char[] tokens = hand.ToCharArray();
                    char power = tokens[0];
                    char type = tokens.Last();

                    switch (power)
                    {
                        case '2':
                            card = 2;
                            break;
                        case '3':
                            card = 3;
                            break;
                        case '4':
                            card = 4;
                            break;
                        case '5':
                            card = 5;
                            break;
                        case '6':
                            card = 6;
                            break;
                        case '7':
                            card = 7;
                            break;
                        case '8':
                            card = 8;
                            break;
                        case '9':
                            card = 9;
                            break;
                        case '1':
                            card = 10;
                            break;
                        case 'J':
                            card = 11;
                            break;
                        case 'Q':
                            card = 12;
                            break;
                        case 'K':
                            card = 13;
                            break;
                        case 'A':
                            card = 14;
                            break;
                    }

                    switch (type)
                    {
                        case 'S':
                            card *= 4;
                            sum+=card;
                            break;
                        case 'H':
                            card *= 3;
                            sum+=card;
                            break;
                        case 'D':
                            card*= 2;
                            sum+=card;
                            break;
                        case 'C':
                            card *= 1;
                            sum+=card;
                            break;
                    }
                }
                Console.WriteLine($"{player.Key}: {sum}");

            }

        }
    }
}
