using System;

namespace ProgrammingBasicExam
{
	class  BasketBattle
	{
		static void Main(string[] args)
		{
			string firstPlayer = Console.ReadLine();
			int n = int.Parse(Console.ReadLine()); // Number of rounds in the game

			int simeonPoints = 0;
			int nakovPoints = 0;

			for (int i = 1; i <= n; i++)
			{
				int firstPlayerPoints = int.Parse(Console.ReadLine());
				string firstPlayerinformation = Console.ReadLine().ToLower();
				int secondPlayerPoints = int.Parse(Console.ReadLine());
				string secondPlayerinformation = Console.ReadLine().ToLower();

				if (firstPlayer == "Simeon")
				{
					if (firstPlayerinformation == "success")
					{
						simeonPoints += firstPlayerPoints;
						simeonPoints = CheckPoints(simeonPoints, firstPlayerPoints);
					}
					if (secondPlayerinformation == "success")
					{
						nakovPoints += secondPlayerPoints;
						nakovPoints = CheckPoints(nakovPoints, secondPlayerPoints);
					}
					firstPlayer = "Nakov";
				}
				else
				{
					if (firstPlayerinformation == "success")
					{
						nakovPoints += firstPlayerPoints;
						nakovPoints = CheckPoints(nakovPoints, firstPlayerPoints);
					}
					if (secondPlayerinformation == "success")
					{
						simeonPoints += secondPlayerPoints;
						simeonPoints = CheckPoints(simeonPoints, secondPlayerPoints);
					}
					firstPlayer = "Simeon";
				}

				if (simeonPoints == 500 || nakovPoints == 500)
				{
					string winner = "Nakov";
					int loserPoints = simeonPoints;
					if (loserPoints == 500)
					{
						loserPoints = nakovPoints;
						winner = "Simeon";
					}

					Console.WriteLine(winner);
					Console.WriteLine(i);
					Console.WriteLine(loserPoints);
					return;
				}
			}

			if (simeonPoints == nakovPoints)
			{
				Console.WriteLine("DRAW");
				Console.WriteLine(nakovPoints);
			}
			else if (simeonPoints != nakovPoints)
			{
				if (simeonPoints > nakovPoints)
				{
					Console.WriteLine("Simeon");
				}
				else
				{
					Console.WriteLine("Nakov");
				}

				Console.WriteLine(Math.Abs(simeonPoints - nakovPoints));
			}
		}

		static int CheckPoints(int playerPoints, int firstSecondPlayerPoints)
		{
			if (playerPoints > 500)
			{
				playerPoints -= firstSecondPlayerPoints;
			}
			return playerPoints;
		}
	}
}
