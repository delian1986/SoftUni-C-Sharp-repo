using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// 90/100
/// </summary>

namespace _03._First_Album
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> album = new Dictionary<string, List<string>>();

            string line = String.Empty;

            while ((line = Console.ReadLine()) != "Rock on!")
            {
                bool validSong = false;
                bool validLirics = false;
                bool validLenght = false;
                string song = "";
                string lirics = "";
                string lenght = "";
                string time = "";

                string songPattern = @"\[([^\s-][\w -]+[^\s-])\]";
                Regex regex = new Regex(songPattern);
                Match m = regex.Match(line);
                if (m.Success)
                {
                    song = m.Groups[1].Value;
                    if (song.Length >= 3)
                    {

                        validSong = true;
                    }
                }


                string liricsPattern = @"""([\w\s]+)""";
                Regex regexLirics = new Regex(liricsPattern);
                Match mLirics = regexLirics.Match(line);
                if (m.Success)
                {
                    lirics = mLirics.Groups[1].Value;
                    if (lirics.Length >= 3)
                    {
                        validLirics = true;
                    }
                }


                string lenghtPattern = @"[\d]+s|[\d]+:[\d]+m";
                Regex regexLenght = new Regex(lenghtPattern);
                Match mLenght = regexLenght.Match(line);
                if (mLenght.Success)
                {
                    lenght = mLenght.Groups[0].Value;
                    if (lenght.EndsWith("s"))
                    {
                        int totalSeconds = int.Parse(lenght.TrimEnd('s'));
                        int seconds = totalSeconds % 60;
                        int minutes = totalSeconds / 60;
                        string min = "";
                        string sec = "";
                        if (minutes < 60)
                        {
                            if (minutes < 10)
                            {
                                min = 0 + minutes.ToString();
                            }
                            else
                            {
                                min = minutes.ToString();
                            }
                            if (seconds < 10)
                            {
                                sec = 0 + seconds.ToString();
                            }
                            else
                            {
                                sec = seconds.ToString();
                            }
                            time = min + ":" + sec;
                            validLenght = true;

                        }

                    }
                    else
                    {
                        lenght = lenght.TrimEnd('m');
                        int posOfDot = lenght.IndexOf(":");
                        string min = lenght.Substring(0, posOfDot);
                        int minutes = int.Parse(min);
                        if (minutes < 60 && min.Length >= 2)
                        {
                            if (min.Length < 2)
                            {
                                min = 0 + min;
                            }
                        }

                        string sec = lenght.Substring(posOfDot + 1, lenght.Length - posOfDot - 1);
                        if (sec.Length < 2)
                        {
                            sec = 0 + sec;
                        }
                        time = min + ":" + sec;
                        validLenght = true;
                    }

                }

                if (validSong && validLirics && validLenght)
                {
                    List<string> names = new List<string>();
                    names.Add(lirics);
                    names.Add(time);

                    if (album.Count < 4)
                    {
                        album.Add(song, names);

                    }
                    else
                    {
                        break;
                    }

                }


            }
            if (album.Count>0)
            {
                foreach (var song in album)
                {
                    Console.WriteLine($"{song.Key} -> {song.Value[1]} => {song.Value[0]}");
                }
            }
            
        }
    }
}
