using System;
using System.Linq;

namespace ProgrammingBasicExam
{
	class Illuminati
	{
		static void Main(string[] args)
		{
			string message = Console.ReadLine().ToLower();
			int countVowels = 0;
			double sumOfVowels = 0;
			string vowels = "aeiou";

			for (int i = 0; i < vowels.Length; i++)
			{
				char vowel = vowels[i];
				if (message.Contains(vowel.ToString()))
				{
					int count = message.Count(f => f == vowel);
					int letterInt = Convert.ToInt32(vowel) - 32;

					sumOfVowels += letterInt * count;
					countVowels += count;
				}
			}

			Console.WriteLine(countVowels);
			Console.WriteLine(sumOfVowels);
		}
	}
}

