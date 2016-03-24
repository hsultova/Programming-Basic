using System;

namespace ProgrammingBasic
{
	class DailyCalorieIntake
	{
		static void Main(string[] args)
		{
			int weight = int.Parse(Console.ReadLine());
			int height = int.Parse(Console.ReadLine());
			int age = int.Parse(Console.ReadLine());
			char gender = char.Parse(Console.ReadLine().ToLower());
			int workouts = int.Parse(Console.ReadLine());

			decimal weightKg = weight / 2.2m;
			decimal heightCm = height * 2.54m;

			decimal bmr = 0;
			decimal dci = 0;

			if (gender == 'm')
			{
				bmr = 66.5m + (13.75m * weightKg) + (5.003m * heightCm) - (6.755m * age);
			}
			else if (gender == 'f')
			{
				bmr = 655m + (9.563m * weightKg) + (1.850m * heightCm) - (4.676m * age);
			}

			if (workouts < 1)
			{
				dci = bmr * 1.2m;
			}
			else if (workouts >= 1 && workouts <= 3)
			{
				dci = bmr * 1.375m;
			}
			else if (workouts >= 4 && workouts <= 6)
			{
				dci = bmr * 1.55m;
			}
			else if (workouts >= 7 && workouts <= 9)
			{
				dci = bmr * 1.725m;
			}
			else
			{
				dci = bmr * 1.9m;
			}

			Console.WriteLine(Math.Floor(dci));
		}
	}
}