using System;
using System.Collections.Generic;

namespace ProgrammingBasic
{
	class  FourFactors
	{
		static void Main(string[] args)
		{
			var fieldGoals = ulong.Parse(Console.ReadLine());
			var fieldGoldAttempts = ulong.Parse(Console.ReadLine());
			var point = ulong.Parse(Console.ReadLine());
			var turnOvers = ulong.Parse(Console.ReadLine());
			var offensiveRebounds = ulong.Parse(Console.ReadLine());
			var opponentDeffensiveRebounds = ulong.Parse(Console.ReadLine());
			var freeThrows = ulong.Parse(Console.ReadLine());
			var freeThrowAttempts = ulong.Parse(Console.ReadLine());

			decimal eFG = (fieldGoals + 0.5m * point) / fieldGoldAttempts;
			decimal TOV = turnOvers / (fieldGoldAttempts + 0.44m * freeThrowAttempts + turnOvers);
			decimal ORB = (decimal) offensiveRebounds / (offensiveRebounds + opponentDeffensiveRebounds);
			decimal FT = (decimal) freeThrows / fieldGoldAttempts;

			Console.WriteLine("eFG% {0:f3}", eFG);
			Console.WriteLine("TOV% {0:f3}", TOV);
			Console.WriteLine("ORB% {0:f3}", ORB);
			Console.WriteLine("FT% {0:f3}", FT);
		}
	}
}