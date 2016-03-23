using System;

namespace ProgrammingExercises
{
	class SaltAndPepper
	{
		static void Main(string[] args)
		{
			var dishes = ulong.Parse(Console.ReadLine());
			string line = Console.ReadLine();

			while (line != "end")
			{
				string spice = line.Split(' ')[0];
				int step = int.Parse(line.Split(' ')[1]);

				if (spice == "salt")
				{
					for (int i = 0; i < 64; i += step)
					{
						if (((dishes >> i) & 1) == 1)
						{
							ulong mask = ~((ulong)1 << i);
							dishes = dishes & mask;
						}
					}
				}
				else if (spice == "pepper")
				{
					for (int i = 0; i < 64; i += step)
					{
						if (((dishes >> i) & 1) == 0)
						{
							ulong mask = ((ulong)1 << i);
							dishes = dishes | mask;
						}
					}
				}
				line = Console.ReadLine();
			}

			Console.WriteLine(dishes);
		}
	}
}