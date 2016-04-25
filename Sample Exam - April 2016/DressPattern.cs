using System;
using System.Linq;

namespace ProgrammingBasicExam
{
	class DressPattern
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int dress = 2;
			int background = 4 * n;

			Console.WriteLine("{0}.{0}.{0}", new string('_', background));

			for (int i = 0; i < 2 * n; i++)
			{
				background -= 2;
				Console.WriteLine("{0}.{1}.{0}.{1}.{0}", new string('_', background), new string('*', dress));
				dress += 3;
			}

			for (int i = 0; i < n; i++)
			{
				dress = 12 * n;
				Console.WriteLine(".{0}.", new string('*', dress));
			}

			background = 3 * n;
			dress = 6 * n + 2;
			Console.WriteLine("{0}{1}{0}", new string('.', background), new string('*', dress));

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("{0}{1}{0}", new string('_', background), new string('o', dress));
			}

			dress -= 2;
			for (int i = 0; i < 3 * n; i++)
			{
				Console.WriteLine("{0}.{1}.{0}", new string('_', background), new string('*', dress));
				background--;
				dress += 2;
			}

			Console.Write(new string('.', 12 * n + 2));
		}
	}
}