using System;

namespace ProgrammingBasic
{
	class  MasterHerbalist
	{
		static void Main(string[] args)
		{
			int countLines = 0;
			int dailyExpenses = 0;
			int totalMoney = 0;
			double averageMoney = 0;
			double diffrance = 0;

			do
			{
				string line = Console.ReadLine();
				if (line == "Season Over")
				{
					break;
				}

				countLines++;

				if (countLines == 1)
				{
					dailyExpenses = int.Parse(line);
					continue;
				}

				string[] tokens = line.Split(' ');
				int hours = int.Parse(tokens[0]);
				string path = tokens[1];
				int price = int.Parse(tokens[2]);

				if (hours > 20) {
					hours = 20;
				}

				int herbs = SearchHerbs(hours, path);
				int dayMoney = herbs * price;
				totalMoney += dayMoney;
			}
			while (true);

			averageMoney =(double) totalMoney / (countLines-1);

			if (averageMoney >= dailyExpenses)
			{
				diffrance = averageMoney - dailyExpenses;
				Console.WriteLine("Times are good. Extra money per day: {0:F2}.", diffrance);
			}
			else
			{
				diffrance = dailyExpenses*(countLines-1) - totalMoney;
				Console.WriteLine("We are in the red. Money needed: {0}.", Math.Round(diffrance));
			}

		}

		public static int SearchHerbs(int hours, string path)
		{
			int herbsFound = 0;
			int end = 0;

			if (hours > path.Length)
			{
				int diffrance = hours - path.Length;
				for (int i = 0; i < diffrance; i++)
				{
					path += path[i];
				}
				end = path.Length;
			}
			else
			{
				end = hours;
			}

			for (int i = 0; i < end; i++)
			{
				if (path[i] == 'H')
				{
					herbsFound++;
				}
			}

			return herbsFound;
		}
	}
}