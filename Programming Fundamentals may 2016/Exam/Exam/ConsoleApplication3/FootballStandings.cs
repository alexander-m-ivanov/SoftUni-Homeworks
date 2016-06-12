using System;
using System.Collections.Generic;
using System.Linq;

class FootballStandings
{
    static void Main()
    {
        string key = Console.ReadLine();
        string[] encryptedLine = Console.ReadLine().Split(' ');

        bool isThisTheEnd = encryptedLine[0].ToLower() == "final";

        string[] teamNames = new string[2];
        int[] MatchScore = new int[2];

        Dictionary<string, int> leagueStandings = new Dictionary<string, int>();
        Dictionary<string, int> topScorer = new Dictionary<string, int>();

        char[] keyLength = key.ToCharArray();
        

        while (isThisTheEnd == false)
        {
            Dictionary<string, int> teamGoalsInMatch = new Dictionary<string, int>();

            //Getting the score of a match out of the encrypted line
            MatchScore = encryptedLine[2].Split(':').Select(int.Parse).ToArray();

            for (int i = 0; i < 2; i++) 
            {
                //Getting the key positions into the encrypted line
                int firstStartPosition = 0;
                int position = encryptedLine[i].IndexOf(key, firstStartPosition);
                firstStartPosition = position;
                int nextStartPosition = firstStartPosition + 1;

                position = encryptedLine[i].IndexOf(key, nextStartPosition);
                int endPosition = position;

                //Findin and extracting the team names from the encrypted line inbetween the keys
                string aTeamName = encryptedLine[i].Substring(firstStartPosition + keyLength.Length, endPosition - (firstStartPosition + keyLength.Length));
                char[] teamNamesReverse = aTeamName.ToCharArray().Reverse().ToArray();
                teamNames[i] = string.Join("", teamNamesReverse).ToUpper();

                //Binding the team goals in a match to the respective team.
                teamGoalsInMatch.Add(teamNames[i], MatchScore[i]);

                //Making a list of total goals per team
                if (topScorer.ContainsKey(teamNames[i]))
                {
                    topScorer[teamNames[i]] += teamGoalsInMatch[teamNames[i]];
                }
                else
                {
                    topScorer.Add(teamNames[i], MatchScore[i]);
                }

                //Making a list of score rankings of teams
                if (i == 1) //Only the 2nd iteration has info for both teams
                {
                    if (teamGoalsInMatch[teamNames[0]] > teamGoalsInMatch[teamNames[1]])
                    {
                        if (leagueStandings.ContainsKey(teamNames[0]))
                        {
                            leagueStandings[teamNames[0]] += 3;
                        }
                        else
                        {
                            leagueStandings.Add(teamNames[0], 3);
                        }

                        if (leagueStandings.ContainsKey(teamNames[1]))
                        {
                            leagueStandings[teamNames[1]] += 0;
                        }
                        else
                        {
                            leagueStandings.Add(teamNames[1], 0);
                        }
                    }
                    else if (teamGoalsInMatch[teamNames[0]] == teamGoalsInMatch[teamNames[1]])
                    {
                        if (leagueStandings.ContainsKey(teamNames[0]))
                        {
                            leagueStandings[teamNames[0]] += 1;
                        }
                        else
                        {
                            leagueStandings.Add(teamNames[0], 1);
                        }

                        if (leagueStandings.ContainsKey(teamNames[1]))
                        {
                            leagueStandings[teamNames[1]] += 1;
                        }
                        else
                        {
                            leagueStandings.Add(teamNames[1], 1);
                        }
                    }
                    else if (teamGoalsInMatch[teamNames[0]] < teamGoalsInMatch[teamNames[1]])
                    {
                        if (leagueStandings.ContainsKey(teamNames[1]))
                        {
                            leagueStandings[teamNames[1]] += 3;
                        }
                        else
                        {
                            leagueStandings.Add(teamNames[1], 3);
                        }

                        if (leagueStandings.ContainsKey(teamNames[0]))
                        {
                            leagueStandings[teamNames[0]] += 0;
                        }
                        else
                        {
                            leagueStandings.Add(teamNames[0], 0);
                        }
                    }
                }
            }
            teamGoalsInMatch.Clear();
            encryptedLine = Console.ReadLine().Split(' ');
            isThisTheEnd = encryptedLine[0].ToLower() == "final";
        }

        Console.WriteLine("League standings:");

        var myList = leagueStandings.ToList();
        myList.Sort((pair2, pair1) => pair1.Value.CompareTo(pair2.Value));

        int counter = 1;
        foreach (var team in myList)
        {
            Console.Write("{0}. ", counter);
            Console.WriteLine(team.Key + " " + team.Value);
            counter += 1;
        }


        Console.WriteLine("Top 3 scored goals:");

        var myList2 = topScorer.ToList();
        myList2.Sort((pair2, pair1) => pair1.Value.CompareTo(pair2.Value));

        foreach (var team in myList2.Take(3))
        {
            Console.Write("- ");
            Console.WriteLine("{0} -> {1}", team.Key, team.Value);
        }
    }
}