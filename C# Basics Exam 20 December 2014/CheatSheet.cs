using System;

namespace ProgrammingBasicExam
{
	class CheatSheet
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());
			int columns = int.Parse(Console.ReadLine());
			int v = int.Parse(Console.ReadLine()); //vertical Start tNumber
			int h = int.Parse(Console.ReadLine()); //horizontal Start Number

			for (long i = v; i < rows + v; i++)
			{
				for (long j = h; j < columns + h; j++)
				{
					Console.Write(i * j +" ");
				}
				Console.WriteLine();
			}
		}
	}
}

