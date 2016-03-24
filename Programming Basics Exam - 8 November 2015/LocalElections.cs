using System;

namespace ProgrammingBasic
{
	class LocalElections
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var vote = int.Parse(Console.ReadLine());
			var voteSymbol = char.Parse(Console.ReadLine().ToLower());

			for (int j = 1; j <= n; j++)
			{
				Console.WriteLine(new string('.', 13));
				Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));

				if (j == vote)
				{
					if (voteSymbol == 'x')
					{
						string numberCandidate = j.ToString();

						Console.WriteLine("{0}|.\\./.|{0}", new string('.', 3));
						
						if (j < 10)
						{
							numberCandidate = "0" + numberCandidate;
						}

						Console.WriteLine("{0}.|..X..|{1}", numberCandidate, new string('.', 3));
						Console.WriteLine("{0}|./.\\.|{0}", new string('.', 3), new string('.', 5));
					}
					else if (voteSymbol == 'v')
					{
						string numberCandidate = j.ToString();

						Console.WriteLine("{0}|\\.../|{0}", new string('.', 3));
						
						if (j < 10)
						{
							numberCandidate = "0" + numberCandidate;
						}

						Console.WriteLine("{0}.|.\\./.|{1}", numberCandidate, new string('.', 3));
						Console.WriteLine("{0}|..V..|{0}", new string('.', 3), new string('.', 5));

					}
					
					Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
				}
				else
				{

					for (int i = 1; i < 3; i++)
					{
						if (i == 2)
						{
							string numberCandidate = j.ToString();
							
							if (j < 10)
							{
								numberCandidate = "0" + numberCandidate;
							}

							Console.WriteLine("{0}.|{1}|{2}", numberCandidate, new string('.', 5), new string('.', 3));
						}
						Console.WriteLine("{0}|{1}|{0}", new string('.', 3), new string('.', 5));
					}
					Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
				}
			}
			Console.WriteLine(new string('.', 13));
		}
	}
}