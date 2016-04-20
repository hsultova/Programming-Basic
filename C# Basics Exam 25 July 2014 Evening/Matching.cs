using System;
using System.Collections.Generic;

namespace ProgrammingBasicExam
{
	class Matching
	{
		static void Main(string[] args)
		{
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			long goodDistance = long.Parse(Console.ReadLine());

			var aSplit = new List<string>();
			var bSplit = new List<string>();
			long distance = 0;
			bool hasOutput = false;

			aSplit = SplitWord(a);
			bSplit = SplitWord(b);

			foreach (string aLine in aSplit)
			{
				string aLeft = "";
				string aRight = "";
				string bLeft = "";
				string bRight = "";

				aLeft = aLine.Split('|')[0];
				aRight = aLine.Split('|')[1];
				foreach (string bLine in bSplit)
				{
					bLeft = bLine.Split('|')[0];
					bRight = bLine.Split('|')[1];

					distance = Math.Abs(CalcWordWeight(aLeft) * CalcWordWeight(bRight) - CalcWordWeight(aRight) * CalcWordWeight(bLeft));
					if (distance <= goodDistance)
					{
						Console.WriteLine("({0}) matches ({1}) by {2} nakovs", aLine, bLine, distance);
						hasOutput = true;
					}
				}
			}
			if (!hasOutput)
			{
				Console.WriteLine("No");
			}
		}

		static List<string> SplitWord(string word)
		{
			var splitWord = new List<string>();
			int count = 0;
			string left = "";
			string right = "";

			for (int i = 0; i < word.Length - 1; i++)
			{
				for (int j = 0; j < word.Length; j++)
				{
					if (j <= count)
					{
						left += word[j];
					}
					else
					{
						right += word[j];
					}
				}

				count++;
				splitWord.Add(left + "|" + right);
				left = "";
				right = "";
			}
			return splitWord;
		}

		static long CalcWordWeight(string word)
		{
			long weight = 0;
			for (int i = 0; i < word.Length; i++)
			{
				int code = Convert.ToInt32(word[i]);
				weight += code;
			}
			return weight;
		}
	}
}