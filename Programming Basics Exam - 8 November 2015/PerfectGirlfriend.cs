using System;

namespace ProgrammingBasic
{
	class PerfectGirlfriend
	{
		static void Main(string[] args)
		{
			var line = Console.ReadLine();
			int countPerfectGirls = 0;
			int result = 0;

			while (line != "Enough dates!")
			{
				string day = line.Split('\\')[0];
				string telephone = line.Split('\\')[1];
				string bra = line.Split('\\')[2];
				string name = line.Split('\\')[3];

				int sumOfTelephoneDigits = 0;
				int dayNumber = 0;
				int braNumber = 0;
				int nameNumber = 0;
				string braNumberAsString = "";

				switch (day)
				{
					case "Monday": dayNumber = 1; break;
					case "Tuesday": dayNumber = 2; break;
					case "Wednesday": dayNumber = 3; break;
					case "Thursday": dayNumber = 4; break;
					case "Friday": dayNumber = 5; break;
					case "Saturday": dayNumber = 6; break;
					case "Sunday": dayNumber = 7; break;
				}

				for (int i = 0; i < telephone.Length; i++)
				{					
					sumOfTelephoneDigits += int.Parse(telephone[i].ToString());
				}

				for (int i = 0; i < bra.Length - 1; i++)
				{
					braNumberAsString += bra[i].ToString();
					braNumber = int.Parse(braNumberAsString);
				}

				braNumber *= Convert.ToInt32(bra[bra.Length - 1]);

				nameNumber = Convert.ToInt32(name[0]) * name.Length;

				result = dayNumber + braNumber - nameNumber;

				if (result < 6000)
				{
					Console.WriteLine("Keep searching, {0} is not for you.", name);
				}
				else
				{
					Console.WriteLine("{0} is perfect for you.", name);
					countPerfectGirls++;
				}

				line = Console.ReadLine();
			}

			Console.WriteLine(countPerfectGirls);

		}
	}
}