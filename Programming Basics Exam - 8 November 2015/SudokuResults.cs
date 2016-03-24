using System;

namespace ProgrammingBasic
{
	class SudokuResults
	{
		static void Main(string[] args)
		{
			var line = Console.ReadLine();
			int countLines = 0;
			int average = 0;
			int sum = 0;
			string star = "";

			while (line != "Quit")
			{
				int minutes = int.Parse(line.Split(':')[0]);
				int seconds = int.Parse(line.Split(':')[1]);
				seconds += minutes * 60;
				sum += seconds;
				countLines++;
				line = Console.ReadLine();
			}

			average = (int) Math.Ceiling(((double)sum / countLines));

			if (average < 720)
			{
				star = "Gold Star";
			}
			else if (average >= 720 && average <= 1440)
			{
				star = "Silver Star";
			}
			else
			{
				star = "Bronze Star";
			}

			Console.WriteLine(star);
			Console.WriteLine("Games - {0} \\ Average seconds - {1}", countLines, average);			
		}
	}
}