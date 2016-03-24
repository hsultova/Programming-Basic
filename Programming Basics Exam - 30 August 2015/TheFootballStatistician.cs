using System;
using System.Collections.Generic;

namespace ProgrammingBasic
{
	class TheFootballStatistician
	{
		static void Main(string[] args)
		{
			decimal payment = decimal.Parse(Console.ReadLine());
			string line = Console.ReadLine();

			int countMatches = 0;
			var teams = new Dictionary<string, int>();
			
			teams.Add("Arsenal", 0);
			teams.Add("Chelsea", 0);
			teams.Add("Everton", 0);
			teams.Add("Liverpool", 0);
			teams.Add("Manchester City", 0);
			teams.Add("Manchester United", 0);
			teams.Add("Southampton", 0);
			teams.Add("Tottenham", 0);

			while (line != "End of the league.")
			{
				string[] tokens = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				string team1 = tokens[0];
				string outcome = tokens[1];
				string team2 = tokens[2];

				//Replace names (two words) with space because of names in dictionary: "ManchesterCity" - "Manchester City" 
				if (team1 == "ManchesterCity")
				{
					team1 = "Manchester City";
				}

				if (team2 == "ManchesterCity")
				{
					team2 = "Manchester City";
				}

				if (team1 == "ManchesterUnited")
				{
					team1 = "Manchester United";
				}

				if (team2 == "ManchesterUnited")
				{
					team2 = "Manchester United";
				}

				if (teams.ContainsKey(team1) && outcome == "1")
				{
					teams[team1] += 3;
				}
				else if (teams.ContainsKey(team2) && outcome == "2")
				{
					teams[team2] += 3;
				}
				else if (teams.ContainsKey(team1) && teams.ContainsKey(team2) && outcome == "X")
				{
					teams[team1] += 1;
					teams[team2] += 1;
				}

				countMatches++;
				line = Console.ReadLine();
			}

			Console.WriteLine("{0:f2}lv.", payment * 1.94m * countMatches);

			foreach (var team in teams)
			{

				Console.WriteLine("{0} - {1} points.", team.Key, team.Value);
			}

		}
	}
}