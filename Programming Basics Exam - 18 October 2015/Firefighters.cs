using System;
using System.Collections.Generic;

namespace ProgrammingBasic
{
	class Firefighters
	{
		static void Main(string[] args)
		{
			int p = int.Parse(Console.ReadLine());
			string line = Console.ReadLine();

			int kids = 0;
			int adults = 0;
			int seniors = 0;
			int n = p;

			while (line != "rain")
			{
				if (p >= line.Length)
				{
					for (int i = 0; i < line.Length; i++)
					{
						if (line[i] == 'K' && p > 0)
						{
							kids++;
							p--;
						}
						else if (line[i] == 'A' && p > 0)
						{
							adults++;
							p--;
						}
						else if (line[i] == 'S' && p > 0)
						{
							seniors++;
							p--;
						}
					}
				}
				else
				{
					while (p > 0)
					{
						for (int i = 0; i < line.Length; i++)
						{
							char[] letters = line.ToCharArray();
							if (line[i] == 'K' && p > 0)
							{
								kids++;
								letters[i] = 'X';
								line = new string(letters);
								p--;
							}
							else if (line[i] == 'A' && p > 0 && !line.Contains("K"))
							{
								adults++;
								letters[i] = 'X';
								line = new string(letters);
								p--;
							}
							else if (line[i] == 'S' && p > 0 && !line.Contains("K") && !line.Contains("A"))
							{
								seniors++;
								p--;
							}
						}
					}
				}
				
				line = Console.ReadLine();
				p = n;
			}

			Console.WriteLine("Kids: {0}", kids);
			Console.WriteLine("Adults: {0}", adults);
			Console.WriteLine("Seniors: {0}", seniors);
		}
	}
}